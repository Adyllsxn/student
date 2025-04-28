namespace Student.Application.UseCases.Postagem.Create;
public class CreatePostagemHandler(IPostagemRepository repository, IUnitOfWork unitOfWork)
{
    public async Task<Result<CreatePostagemResponse>> CreateHandler(CreatePostagemCommand command, CancellationToken token)
    {
        try
        {
            var entity = command.MapToPostagemEntity();
            var response = await repository.CreateAsync(entity, token);
            await unitOfWork.CommitAsync();

            return new Result<CreatePostagemResponse>(
                response.Data?.MapToCreatePostagem(), 
                response.Code, 
                response.Message
            );
        }
        catch(Exception ex)
        {
            return new Result<CreatePostagemResponse>(
                null, 
                500, 
                $"Erro ao manipular a operação (CRIAR). Erro: {ex.Message}"
                );
        }
    }
}
