namespace Student.Domain.Abstractions.Interfaces;
public interface IUsuarioRepository
{
    Task<Result<UsuarioEntity>> CreateAsync (UsuarioEntity entity, CancellationToken token);
    Task<Result<bool>> DeleteAsync (int entityId, CancellationToken token);
    Task<Result<UsuarioEntity?>> GetByIdAsync (int entityId, CancellationToken token);
    Task<PagedList<List<UsuarioEntity>?>> GetAllAsync (PagedRequest request, CancellationToken token);
    Task<Result<UsuarioEntity>> UpdateAsync (UsuarioEntity entity, CancellationToken token);
    Task<Result<List<UsuarioEntity>?>> SearchAsync (Expression<Func<UsuarioEntity, bool>> expression, string entity, CancellationToken token);
}
