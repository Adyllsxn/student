namespace Student.Domain.Abstractions.Interfaces;
public interface IDashboardRepository
{
    Task<DashboardEntity> GetQtdItems(CancellationToken token);
}
