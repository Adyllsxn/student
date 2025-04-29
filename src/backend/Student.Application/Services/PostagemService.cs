namespace Student.Application.Services;
public class PostagemService(CreatePostagemHandler create, GetFilePostagemHandler getFile, GetPostagemByIdHandler getById, DeletePostagemHandler delete, GetPostagensHandler get, SearchPostagemHandler search, UpdatePostagemHandler update) : IPostagemService
{
    public async Task<Result<CreatePostagemResponse>> CreateHandler(CreatePostagemCommand command, CancellationToken token)
    {
        return await create.CreateHandler(command, token);
    }

    public async Task<Result<bool>> DeleteHandler(DeletePostagemCommand command, CancellationToken token)
    {
        return await delete.DeleteHandler(command, token);
    }

    public async Task<PagedList<List<GetPostagensResponse>?>> GetHandler(GetPostagensCommand command, CancellationToken token)
    {
        return await get.GetHandler(command, token);
    }

    public async Task<Result<GetPostagemByIdResponse>> GetByIdHandler(GetPostagemByIdCommand command, CancellationToken token)
    {
        return await getById.GetByIdHandler(command,token);
    }

    public async Task<Result<GetFilePostagemResponse>> GetFileHandler(GetFilePostagemCommand command, CancellationToken token)
    {
        return await getFile.GetFileHandler(command, token);
    }

    public async Task<Result<List<SearchPostagemResponse>>> SearchHendler(SearchPostagemCommand command, CancellationToken token)
    {
        return await search.SearchHendler(command, token);
    }

    public async Task<Result<UpdatePostagemResponse>> UpdateHendler(UpdatePostagemCommand command, CancellationToken token)
    {
        return await update.UpdateHendler(command, token);
    }
}
