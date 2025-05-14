namespace Student.Application.UseCases.TipoUsuario.Create;
public class CreateTipoUsuarioHandler(ITipoUsuarioRepository repository, IUnitOfWork unitOfWork)
{
    public async Task<Result<CreateTipoUsuarioResponse>> CreateHandler(CreateTipoUsuarioCommand command, CancellationToken token)
    {
        try
        {
            var entity = command.MapToTipoUsuarioEntity();
            var response = await repository.CreateAsync(entity, token);
            await unitOfWork.CommitAsync();

            return new Result<CreateTipoUsuarioResponse>(
                response.Data?.MapToCreateTipoUsuario(), 
                response.Code, 
                response.Message
            );
        }
        catch(Exception ex)
        {
            return new Result<CreateTipoUsuarioResponse>(
                null, 
                500, 
                $"Erro ao manipular a operação (CRIAR). Erro: {ex.Message}"
                );
        }
    }
}
