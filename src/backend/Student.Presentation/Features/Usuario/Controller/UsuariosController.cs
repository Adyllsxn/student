namespace Student.Presentation.Features.Usuario.Controller;
[ApiController]
[Route("v1/")]
public class UsuariosController(IUsuarioService service) : ControllerBase
{
    #region </GetAll>
        [HttpGet("Usuários"), EndpointSummary("Obter Usuários")]
        public async Task<IActionResult> GetAllAsync([FromQuery] GetUsuariosCommand command, CancellationToken token)
        {
            var response = await service.GetHandler(command, token);
            return Ok(response);
        }
    #endregion

    #region </GetById>
        [HttpGet("UsuárioById"), EndpointSummary("Obter Usuário Pelo Id")]
        public async Task<IActionResult> GetByIdAsync([FromQuery] GetUsuarioByIdCommand command, CancellationToken token)
        {
            var response = await service.GetByIdHandler(command,token);
            return Ok(response);
        }
    #endregion

    #region </Search>
        [HttpGet("SearchUsuário"), EndpointSummary("Pesquisar Usuário")]
        public async Task<IActionResult> SearchAsync([FromQuery] SearchUsuarioCommand command, CancellationToken token)
        {
            var response = await service.SearchHendler(command,token);
            return Ok(response);
        }
    #endregion

    #region </Create>
        [HttpPost("CreateUsuário"), EndpointSummary("Adicionar Usuário")]
        public async Task<IActionResult> CreateAsync(CreateUsuarioCommand command, CancellationToken token)
        {
            var response = await service.CreateHandler(command,token);
            return Ok(response);
        }
    #endregion

    #region </Delete>
        [HttpDelete("DeleteUsuário"), EndpointSummary("Excluir Usuário")]
        public async Task<IActionResult> DeleteAsync(DeleteUsuarioCommand command, CancellationToken token)
        {
            var response = await service.DeleteHandler(command,token);
            return Ok(response);
        }
    #endregion

    #region </Update>
        [HttpPut("UpdateUsuário"), EndpointSummary("Editar Usuário")]
        public async Task<IActionResult> UpdateAsync(UpdateUsuarioCommand command, CancellationToken token)
        {
            var response = await service.UpdateHendler(command,token);
            return Ok(response);
        }
    #endregion


}