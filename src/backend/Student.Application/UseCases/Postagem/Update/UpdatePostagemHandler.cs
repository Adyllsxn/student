namespace Student.Application.UseCases.Postagem.Update;
public class UpdatePostagemHandler(IPostagemRepository repository, IUnitOfWork unitOfWork)
{
    public async Task<Result<UpdatePostagemResponse>> UpdateHendler(UpdatePostagemCommand command, CancellationToken token)
    {
        try
        {
            var entity = command.MapToPostagemEntity();
            var response = await repository.UpdateAsync(entity, token);
            await unitOfWork.CommitAsync();

            return new Result<UpdatePostagemResponse>(
                response.Data?.MapToUpdatePostagem(),
                response.Code,
                response.Message
            );
        }
        catch(Exception ex)
        {
            return new Result<UpdatePostagemResponse>(
                null, 
                500, 
                $"Erro ao manipular a operação (UPDATE). Erro: {ex.Message}"
                );
        }
    }
}