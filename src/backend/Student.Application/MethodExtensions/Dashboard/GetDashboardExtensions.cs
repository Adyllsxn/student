namespace Student.Application.MethodExtensions.Dashboard;
public static class GetDashboardExtensions
{
    public static GetDashboardResponse MapToGetDashboard (this DashboardEntity entity)
    {
        return new GetDashboardResponse
        {
            QtdCategoria = entity.QtdCategoria,
            QtdPostagem = entity.QtdPostagem
        };
    }
    public static IEnumerable<GetDashboardResponse> MapToGetDashboard(this IEnumerable<DashboardEntity> response)
    {
        return response.Select(entity => entity.MapToGetDashboard());
    }
}
