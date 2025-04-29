namespace Student.Application.Abstractions.Interfaces;
public interface IPostagemService
{
    Task<Result<CreatePostagemResponse>> CreateHandler(CreatePostagemCommand command, CancellationToken token);
    Task<Result<GetFilePostagemResponse>> GetFileHandler(GetFilePostagemCommand command, CancellationToken token);
    Task<Result<GetPostagemByIdResponse>> GetByIdHandler(GetPostagemByIdCommand command, CancellationToken token);
    Task<Result<bool>> DeleteHandler(DeletePostagemCommand command, CancellationToken token);
    Task<PagedList<List<GetPostagensResponse>?>> GetAllAsync(PagedRequest request, CancellationToken token);
}