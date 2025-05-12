namespace Student.Application.MethodExtensions.Usuario;
public static class UpdateUsuarioExtensions
{
    public static UsuarioEntity MapToUsuarioEntity(this UpdateUsuarioCommand command)
    {
        return new UsuarioEntity
        (
            command.Id,
            command.Nome,
            command.Email 
        );
    }
    
    public static UpdateUsuarioResponse MapToUpdateUsuario (this UsuarioEntity entity)
    {
        return new UpdateUsuarioResponse
        {
            Id = entity.Id,
            Nome = entity.Nome,
            Email = entity.Email
        };
    }
    public static IEnumerable<UpdateUsuarioResponse> MapToUpdateUsuario(this IEnumerable<UsuarioEntity> response)
    {
        return response.Select(entity => entity.MapToUpdateUsuario());
    }
}
