namespace Student.Domain.Abstractions.Interfaces;
public interface ITipoUsuarioRepository
{
    Task<Result<TipoUsuarioEntity>> CreateAsync (TipoUsuarioEntity entity, CancellationToken token);
    Task<Result<bool>> DeleteAsync (int entityId, CancellationToken token);
    Task<Result<TipoUsuarioEntity?>> GetByIdAsync (int entityId, CancellationToken token);
    Task<PagedList<List<TipoUsuarioEntity>?>> GetAllAsync (PagedRequest request, CancellationToken token);
    Task<Result<TipoUsuarioEntity>> UpdateAsync (TipoUsuarioEntity entity, CancellationToken token);
    Task<Result<List<TipoUsuarioEntity>?>> SearchAsync (Expression<Func<TipoUsuarioEntity, bool>> expression, string entity, CancellationToken token);
}
