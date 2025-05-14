using Student.Application.UseCases.TipoUsuario.Create;

namespace Student.Application.MethodExtensions.TipoUsuario;
public static class CreateTipoUsuarioExtensions
{
    public static TipoUsuarioEntity MapToTipoUsuarioEntity(this CreateTipoUsuarioCommand command)
    {
        return new TipoUsuarioEntity
        (
            command.Nome
        );
    }
    
    public static CreateTipoUsuarioResponse MapToCreateTipoUsuario (this TipoUsuarioEntity entity)
    {
        return new CreateTipoUsuarioResponse
        {
            Id = entity.Id,
            Nome = entity.Nome
        };
    }
    public static IEnumerable<CreateTipoUsuarioResponse> MapToCreateTipoUsuario(this IEnumerable<TipoUsuarioEntity> response)
    {
        return response.Select(entity => entity.MapToCreateTipoUsuario());
    }
}
