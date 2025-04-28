namespace Student.Presentation.Features.Dashboard.Controller;
[ApiController]
[Route("v1/")]
public class DashboardController(IDashboardService service) : ControllerBase
{
    #region </Dashboard>
        [HttpGet("Dashboard"), EndpointSummary("Painel de todas entidades.")]
        public async Task<ActionResult> Dashboard(CancellationToken token)
        {
            var response = await service.GetHandler(token);
            return Ok(
                $" CATEGORIA: {response.QtdCategoria} \n POSTAGEM: {response.QtdPostagem}"
            );
        }
    #endregion
}
