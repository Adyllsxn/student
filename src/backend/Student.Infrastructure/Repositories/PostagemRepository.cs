namespace Student.Infrastructure.Repositories;
public class PostagemRepository : IPostagemRepository
{
    public Task<Result<PostagemEntity>> CreateAsync(PostagemEntity entity, CancellationToken token)
    {
        throw new NotImplementedException();
    }

    public Task<Result<bool>> DeleteAsync(int entityId, CancellationToken token)
    {
        throw new NotImplementedException();
    }

    public Task<PagedList<List<PostagemEntity>?>> GetAllAsync(CancellationToken token)
    {
        throw new NotImplementedException();
    }

    public Task<Result<PostagemEntity?>> GetByIdAsync(int entityId, CancellationToken token)
    {
        throw new NotImplementedException();
    }

    public Task<Result<PostagemEntity?>> GetFileAsync(int entityId, CancellationToken token)
    {
        throw new NotImplementedException();
    }

    public Task<PagedList<List<PostagemEntity>?>> SearchAsync(Expression<Func<PostagemEntity, bool>> expression, string entity, CancellationToken token)
    {
        throw new NotImplementedException();
    }

    public Task<Result<PostagemEntity>> UpdateAsync(PostagemEntity entity, CancellationToken token)
    {
        throw new NotImplementedException();
    }
}
