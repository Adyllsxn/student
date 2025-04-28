namespace Student.Application.Abstractions.Interfaces;
public interface ICategoriaService
{
    Task<Result<CreateCategoriaResponse>> CreateHandler(CreateCategoriaCommand command, CancellationToken token);
    Task<Result<bool>> DeleteHandler(DeleteCategoriaCommand command, CancellationToken token);
    Task<Result<List<GetCategoriasResponse>>> GetHandler(CancellationToken token);
    Task<Result<GetCategoriaByIdResponse>> GetByIdHandler(GetCategoriaByIdCommand command, CancellationToken token);
    Task<Result<List<SearchCategoriaResponse>>> SearchHendler(SearchCategoriaCommand command, CancellationToken token);
    Task<Result<UpdateCategoriaResponse>> UpdateHendler(UpdateCategoriaCommand command, CancellationToken token);
}
