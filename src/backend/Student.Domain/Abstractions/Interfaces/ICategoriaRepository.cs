namespace Student.Domain.Abstractions.Interfaces;
public interface ICategoriaRepository
{
    Task<Result<CategoriaEntity>> CreateAsync (CategoriaEntity entity, CancellationToken token);
    Task<Result<bool>> DeleteAsync (int entityId, CancellationToken token);
    Task<Result<CategoriaEntity?>> GetByIdAsync (int entityId, CancellationToken token);
    Task<Result<List<CategoriaEntity>?>> GetAllAsync (CancellationToken token);
    Task<Result<CategoriaEntity>> UpdateAsync (CategoriaEntity entity, CancellationToken token);
    Task<Result<List<CategoriaEntity>?>> SearchAsync (Expression<Func<CategoriaEntity, bool>> expression, string entity, CancellationToken token);
}
