namespace Student.Application.Services;
public class PostagemService(CreatePostagemHandler create) : IPostagemService
{
    public async Task<Result<CreatePostagemResponse>> CreateHandler(CreatePostagemCommand command, CancellationToken token)
    {
        return await create.CreateHandler(command, token);
    }
}
