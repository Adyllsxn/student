namespace Student.Application.UseCases.Categoria.Delete;
public class DeleteCategoriaHandler(ICategoriaRepository repository, IUnitOfWork unitOfWork)
{
    public async Task<Result<bool>> DeleteHandler(DeleteCategoriaCommand command, CancellationToken token)
    {
        try
        {
            var response = await repository.DeleteAsync(command.Id, token);
            await unitOfWork.CommitAsync();
            return new Result<bool>(
                response.Data,
                response.Code,
                response.Message
            );
        }
        catch(Exception ex)
        {
            return new Result<bool>(
                false,
                500,
                $"Erro ao manipular a operação (DELETAR). Erro: {ex.Message}"
            );
        }
    }
}
