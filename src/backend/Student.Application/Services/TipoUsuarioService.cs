namespace Student.Application.Services;
public class TipoUsuarioService(CreateTipoUsuarioHandler create, DeleteTipoUsuarioHandler delete, GetTipoUsuariosHandler get, GetTipoUsuarioByIdHandler getById, SearchTipoUsuarioHandler search, UpdateTipoUsuarioHandler update) : ITipoUsuarioService
{
    public async Task<Result<CreateTipoUsuarioResponse>> CreateHandler(CreateTipoUsuarioCommand command, CancellationToken token)
    {
        return await create.CreateHandler(command, token);
    }

    public async Task<Result<bool>> DeleteHandler(DeleteTipoUsuarioCommand command, CancellationToken token)
    {
        return await delete.DeleteHandler(command, token);
    }

    public async Task<Result<GetTipoUsuarioByIdResponse>> GetByIdHandler(GetTipoUsuarioByIdCommand command, CancellationToken token)
    {
        return await getById.GetByIdHandler(command, token);
    }

    public async Task<PagedList<List<GetTipoUsuariosResponse>?>> GetHandler(GetTipoUsuariosCommand command, CancellationToken token)
    {
        return await get.GetHandler(command, token);
    }

    public async Task<Result<List<SearchTipoUsuarioResponse>>> SearchHendler(SearchTipoUsuarioCommand command, CancellationToken token)
    {
        return await search.SearchHendler(command, token);
    }

    public async Task<Result<UpdateTipoUsuarioResponse>> UpdateHendler(UpdateTipoUsuarioCommand command, CancellationToken token)
    {
        return await update.UpdateHendler(command, token);
    }
}
