namespace Student.Application.MethodExtensions.Usuario;
public static class CreateUsuarioExtensions
{
    public static UsuarioEntity MapToUsuarioEntity(this CreateUsuarioCommand command)
    {

        return new UsuarioEntity
        (
            command.Nome,
            command.Email,
            command.TipoUsuarioId ?? 2
        );
    }
    
    public static CreateUsuarioResponse MapToCreateUsuario (this UsuarioEntity entity)
    {
        return new CreateUsuarioResponse
        {
            Id = entity.Id,
            Nome = entity.Nome,
            Email = entity.Email,
            TipoUsuarioId = entity.TipoUsuarioId
        };
    }
    public static IEnumerable<CreateUsuarioResponse> MapToCreateUsuario(this IEnumerable<UsuarioEntity> response)
    {
        return response.Select(entity => entity.MapToCreateUsuario());
    }
}
