namespace Student.Infrastructure.Repositories;
public class DashboardRepository(AppDbContext context) : IDashboardRepository
{
    public async Task<DashboardEntity> GetQtdItems(CancellationToken token)
    {
        DashboardEntity entity =  new  DashboardEntity();
        entity.QtdCategoria = await context.Categorias.CountAsync(token);
        entity.QtdPostagem = await context.Postagens.CountAsync(token);
        return entity;
    }
}
