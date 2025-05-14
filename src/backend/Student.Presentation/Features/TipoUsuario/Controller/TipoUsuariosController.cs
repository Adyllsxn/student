namespace Student.Presentation.Features.TipoUsuario.Controller;
[ApiController]
[Route("api/")]
public class TipoUsuariosController(ITipoUsuarioService service) : ControllerBase
{
    
    #region </GetAll>
        [HttpGet("TipoUsuarios"), EndpointSummary("Obter tipos de usuarios")]
        public async Task<IActionResult> GetAllAsync([FromQuery] GetTipoUsuariosCommand command, CancellationToken token)
        {
            var response = await service.GetHandler(command, token);
            return Ok(response);
        }
    #endregion

    #region </GetById>
        [HttpGet("TipoUsuarioById"), EndpointSummary("Obter Tipo de usuário Pelo Id")]
        public async Task<IActionResult> GetByIdAsync([FromQuery] GetTipoUsuarioByIdCommand command, CancellationToken token)
        {
            var response = await service.GetByIdHandler(command,token);
            return Ok(response);
        }
    #endregion

    #region </Search>
        [HttpGet("SearchTipoUsuario"), EndpointSummary("Pesquisar tipo de usuário")]
        public async Task<IActionResult> SearchAsync([FromQuery] SearchTipoUsuarioCommand command, CancellationToken token)
        {
            var response = await service.SearchHendler(command,token);
            return Ok(response);
        }
    #endregion

    #region </Create>
        [HttpPost("CreateTipoUsuario"), EndpointSummary("Adicionar Tipo de usuário")]
        [Authorize]
        public async Task<IActionResult> CreateAsync(CreateTipoUsuarioCommand command, CancellationToken token)
        {
            var response = await service.CreateHandler(command,token);
            return Ok(response);
        }
    #endregion

    #region </Delete>
        [HttpDelete("DeleteTipoUsuario"), EndpointSummary("Excluir Tipo de usuário")]
        public async Task<IActionResult> DeleteAsync(DeleteTipoUsuarioCommand command, CancellationToken token)
        {
            var response = await service.DeleteHandler(command,token);
            return Ok(response);
        }
    #endregion

    #region </Update>
        [HttpPut("UpdateTipoUsuario"), EndpointSummary("Editar Tipo de usuário")]
        public async Task<IActionResult> UpdateAsync(UpdateTipoUsuarioCommand command, CancellationToken token)
        {
            var response = await service.UpdateHendler(command,token);
            return Ok(response);
        }
    #endregion

}
