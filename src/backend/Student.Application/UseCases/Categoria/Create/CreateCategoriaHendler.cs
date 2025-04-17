namespace Student.Application.UseCases.Categoria.Create;
public class CreateCategoriaHendler(ICategoriaRepository repository, IUnitOfWork unitOfWork)
{
    public async Task<Result<CreateCategoriaResponse>> CreateHandler(CreateCategoriaCommand command, CancellationToken token)
    {
        try
        {
            var entity = command.MapToCreateCategoria();
            var response = await repository.CreateAsync(entity, token);
            await unitOfWork.CommitAsync();

            return new Result<CreateCategoriaResponse>(
                response.Data?.MapToCreateCategorias(), 
                response.Code, 
                response.Message
            );
        }
        catch(Exception ex)
        {
            return new Result<CreateCategoriaResponse>(
                null, 
                500, 
                $"Erro ao manipular a operação (CRIAR). Erro: {ex.Message}");
        }
    }
}
