public class UpdateTipoUsuarioHandler(ITipoUsuarioRepository repository, IUnitOfWork unitOfWork)
{
    public async Task<Result<UpdateTipoUsuarioResponse>> UpdateHendler(UpdateTipoUsuarioCommand command, CancellationToken token)
    {
        try
        {
            var entity = command.MapToTipoUsuarioEntity();
            var response = await repository.UpdateAsync(entity, token);
            await unitOfWork.CommitAsync();

            return new Result<UpdateTipoUsuarioResponse>(
                response.Data?.MapToUpdateTipoUsuario(),
                response.Code,
                response.Message
            );
        }
        catch(Exception ex)
        {
            return new Result<UpdateTipoUsuarioResponse>(
                null, 
                500, 
                $"Erro ao manipular a operação (UPDATE). Erro: {ex.Message}"
                );
        }
    }
}
