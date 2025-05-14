using Student.Application.UseCases.TipoUsuario.Update;

namespace Student.Application.MethodExtensions.TipoUsuario;
public static class UpdateTipoUsuarioExtensions
{
    public static TipoUsuarioEntity MapToTipoUsuarioEntity(this UpdateTipoUsuarioCommand command)
        => new(command.Id, command.Nome);
    
    public static UpdateTipoUsuarioResponse MapToUpdateTipoUsuario (this TipoUsuarioEntity entity)
    {
        return new UpdateTipoUsuarioResponse
        {
            Id = entity.Id,
            Nome = entity.Nome
        };
    }
    public static IEnumerable<UpdateTipoUsuarioResponse> MapToUpdateTipoUsuario(this IEnumerable<TipoUsuarioEntity> response)
    {
        return response.Select(entity => entity.MapToUpdateTipoUsuario());
    }
}
