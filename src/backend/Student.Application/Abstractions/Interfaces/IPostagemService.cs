namespace Student.Application.Abstractions.Interfaces;
public interface IPostagemService
{
    Task<Result<CreatePostagemResponse>> CreateHandler(CreatePostagemCommand command, CancellationToken token);
    Task<Result<GetFilePostagemResponse>> GetFileHandler(GetFilePostagemCommand command, CancellationToken token);
}