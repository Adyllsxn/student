namespace Student.Application.UseCases.Categoria.Update;
public class UpdateCategoriaHandler(ICategoriaRepository repository, IUnitOfWork unitOfWork)
{
    public async Task<Result<UpdateCategoriaResponse>> UpdateHendler(UpdateCategoriaCommand command, CancellationToken token)
    {
        try
        {
            var entity = command.MapToCategoriaEntity();
            var response = await repository.UpdateAsync(entity, token);
            await unitOfWork.CommitAsync();

            return new Result<UpdateCategoriaResponse>(
                response.Data?.MapToUpdateCategoria(),
                response.Code,
                response.Message
            );
        }
        catch(Exception ex)
        {
            return new Result<UpdateCategoriaResponse>(
                null, 
                500, 
                $"Erro ao manipular a operação (UPDATE). Erro: {ex.Message}"
                );
        }
    }
}
