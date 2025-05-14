namespace Student.Application.Abstractions.Interfaces;
public interface ITipoUsuarioService
{
    Task<Result<CreateTipoUsuarioResponse>> CreateHandler(CreateTipoUsuarioCommand command, CancellationToken token);
    Task<Result<bool>> DeleteHandler(DeleteTipoUsuarioCommand command, CancellationToken token);
    Task<PagedList<List<GetTipoUsuariosResponse>?>> GetHandler(GetTipoUsuariosCommand command, CancellationToken token);
    Task<Result<GetTipoUsuarioByIdResponse>> GetByIdHandler(GetTipoUsuarioByIdCommand command, CancellationToken token);
    Task<Result<List<SearchTipoUsuarioResponse>>> SearchHendler(SearchTipoUsuarioCommand command, CancellationToken token);
    Task<Result<UpdateTipoUsuarioResponse>> UpdateHendler(UpdateTipoUsuarioCommand command, CancellationToken token);
}
