namespace Student.Presentation.Features.Usuario.Controller;
[ApiController]
[Route("v1/")]
public class UsuariosController(IUsuarioService service, IAuthenticationIdentity authentication) : ControllerBase
{

    #region </Register>
        [HttpPost("Register"), EndpointSummary("Registrar um novo usuário.")]
        public async Task<ActionResult<TokenModel>> Register(CreateUsuarioCommand command, CancellationToken token)
        {
            var emailExist = await authentication.UserExistAsync(command.Email);
            if(emailExist)
            {
                return BadRequest("Este email já possui um cadastro.");
            }

            var response = await service.CreateHandler(command,token);
            if(response == null)
            {
                return BadRequest("Ocorreu um erro ao cadastrar.");
            }

            var tokenReturn = authentication.GenerateTokenAsync(command.Id, command.Email);
            return new TokenModel{
                Token = tokenReturn
            };
        }
    #endregion

    #region </Login>
        [HttpPost("Login"), EndpointSummary("Fazendo o login no sistema")]
        public async Task<ActionResult<TokenModel>> Login(LoginModel login)
        {
            var emailExist = await authentication.UserExistAsync(login.Email);
            if(!emailExist)
            {
                return Unauthorized("Usuário não existe");
            }
            
            var result = authentication.AuthenticateAsync(login.Email, login.Password);
            if(result == null)
            {
                return Unauthorized("Usuário ou Senha Inválida.");
            }

            var usuario = await authentication.GetUserByEmailAsync(login.Email);
            if (usuario == null)
            {
                return Unauthorized("Usuário não encontrado.");
            }

            var createToken = authentication.GenerateTokenAsync(usuario.Id, usuario.Email);

            return new TokenModel{
                Token = createToken
            };
        }
    #endregion

}