namespace Student.Presentation.Features.Categoria.Controller;
[ApiController]
[Route("v1/")]
public class CategoriasController(ICategoriaService service) : ControllerBase
{
    #region </GetAll>
        [HttpGet("Categorias"), EndpointSummary("Obter Categorias")]
        public async Task<IActionResult> GetAllAsync(CancellationToken token)
        {
            var response = await service.GetHandler(token);
            return Ok(response);
        }
    #endregion

    #region </GetById>
        [HttpGet("CategoriaById"), EndpointSummary("Obter Categoria Pelo Id")]
        public async Task<IActionResult> GetByIdAsync([FromQuery] GetCategoriaByIdCommand command, CancellationToken token)
        {
            var response = await service.GetByIdHandler(command,token);
            return Ok(response);
        }
    #endregion

    #region </Search>
        [HttpGet("SearchCategoria"), EndpointSummary("Pesquisar Categoria")]
        public async Task<IActionResult> SearchAsync([FromQuery] SearchCategoriaCommand command, CancellationToken token)
        {
            var response = await service.SearchHendler(command,token);
            return Ok(response);
        }
    #endregion

    #region </Create>
        [HttpPost("CreateCategoria"), EndpointSummary("Adicionar Categoria")]
        [Authorize]
        public async Task<IActionResult> CreateAsync(CreateCategoriaCommand command, CancellationToken token)
        {
            var response = await service.CreateHandler(command,token);
            return Ok(response);
        }
    #endregion

    #region </Delete>
        [HttpDelete("DeleteCategoria"), EndpointSummary("Excluir Categoria")]
        public async Task<IActionResult> DeleteAsync(DeleteCategoriaCommand command, CancellationToken token)
        {
            var response = await service.DeleteHandler(command,token);
            return Ok(response);
        }
    #endregion

    #region </Update>
        [HttpPut("UpdateCategoria"), EndpointSummary("Editar Categoria")]
        public async Task<IActionResult> UpdateAsync(UpdateCategoriaCommand command, CancellationToken token)
        {
            var response = await service.UpdateHendler(command,token);
            return Ok(response);
        }
    #endregion

}
