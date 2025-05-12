namespace Student.Application.MethodExtensions.Usuario;
public static class GetUsuariosExtensions
{
    public static GetUsuariosResponse MapToGetUsuarios (this UsuarioEntity entity)
    {
        return new GetUsuariosResponse
        {
            Id = entity.Id,
            Nome = entity.Nome,
            Email = entity.Email,
        };
    }
    public static IEnumerable<GetUsuariosResponse> MapToGetUsuarios(this IEnumerable<UsuarioEntity> response)
    {
        return response.Select(entity => entity.MapToGetUsuarios());
    }
}
