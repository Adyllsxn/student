namespace Student.Application.Abstractions.Interfaces;
public interface IPostagemService
{
    Task<Result<CreatePostagemResponse>> CreateHandler(CreatePostagemCommand command, CancellationToken token);
}