namespace Student.Presentation.Features.Dashboard.Controller;
[ApiController]
[Route("v1/")]
[Authorize]
public class DashboardController(IDashboardService service) : ControllerBase
{
    #region </Dashboard>
        [HttpGet("Dashboard"), EndpointSummary("Painel de todas entidades.")]
        public async Task<ActionResult> Dashboard(CancellationToken token)
        {
            var response = await service.GetHandler(token);
            return Ok(
                $" CATEGORIA: {response.QtdCategoria} \n POSTAGEM: {response.QtdPostagem} \n USUÁRIO: {response.QtdUsuario} \n TIPO USUÁRIO: {response.QtdTipoUsuario}"
            );
        }
    #endregion
}
