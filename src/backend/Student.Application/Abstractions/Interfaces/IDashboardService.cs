namespace Student.Application.Abstractions.Interfaces;
public interface IDashboardService
{
    Task<GetDashboardResponse> GetHandler(CancellationToken token);
}