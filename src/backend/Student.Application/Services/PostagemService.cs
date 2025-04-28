namespace Student.Application.Services;
public class PostagemService(CreatePostagemHandler create, GetFilePostagemHandler getFile) : IPostagemService
{
    public async Task<Result<CreatePostagemResponse>> CreateHandler(CreatePostagemCommand command, CancellationToken token)
    {
        return await create.CreateHandler(command, token);
    }

    public async Task<Result<GetFilePostagemResponse>> GetFileHandler(GetFilePostagemCommand command, CancellationToken token)
    {
        return await getFile.GetFileHandler(command, token);
    }
}
