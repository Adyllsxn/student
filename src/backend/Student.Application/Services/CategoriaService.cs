namespace Student.Application.Services;
public class CategoriaService(CreateCategoriaHendler create, DeleteCategoriaHandler delete, GetCategoriasHandler get, GetCategoriaByIdHandler getbyid, SearchCategoriaHandler search, UpdateCategoriaHandler update) : ICategoriaService
{
    public async Task<Result<CreateCategoriaResponse>> CreateHandler(CreateCategoriaCommand command, CancellationToken token)
    {
        return await create.CreateHandler(command, token);
    }

    public async Task<Result<bool>> DeleteHandler(DeleteCategoriaCommand command, CancellationToken token)
    {
        return await delete.DeleteHandler(command, token);
    }

    public async Task<Result<GetCAtegoriaByIdResponse>> GetByIdHandler(GetCategoriaByIdCommand command, CancellationToken token)
    {
        return await getbyid.GetByIdHandler(command, token);
    }

    public async Task<Result<List<GetCategoriasResponse>>> GetHandler(CancellationToken token)
    {
        return await get.GetHandler(token);
    }

    public async Task<Result<List<SearchCategoriaResponse>>> SearchHendler(SearchCategoriaCommand command, CancellationToken token)
    {
        return await search.SearchHendler(command,token);
    }

    public async Task<Result<UpdateCategoriaResponse>> UpdateHendler(UpdateCategoriaCommand command, CancellationToken token)
    {
        return await update.UpdateHendler(command, token);
    }
}
