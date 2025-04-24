namespace Student.Domain.Abstractions.Interfaces;
public interface IPostagemRepository
{
    Task<Result<PostagemEntity>> CreateAsync (PostagemEntity entity, CancellationToken token);
    Task<Result<bool>> DeleteAsync (int entityId, CancellationToken token);
    Task<Result<PostagemEntity?>> GetByIdAsync (int entityId, CancellationToken token);
    Task<Result<PostagemEntity?>> GetFileAsync (int entityId, CancellationToken token);
    Task<PagedList<List<PostagemEntity>?>> GetAllAsync (PagedRequest request, CancellationToken token);
    Task<Result<PostagemEntity>> UpdateAsync (PostagemEntity entity, CancellationToken token);
    Task<Result<List<PostagemEntity>?>> SearchAsync (Expression<Func<PostagemEntity, bool>> expression, string entity, CancellationToken token);
}
