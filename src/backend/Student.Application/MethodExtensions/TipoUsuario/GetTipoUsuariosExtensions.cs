namespace Student.Application.MethodExtensions.TipoUsuario;
public static class GetTipoUsuariosExtensions
{
    public static GetTipoUsuariosResponse MapToGetTipoUsuarios (this TipoUsuarioEntity entity)
    {
        return new GetTipoUsuariosResponse
        {
            Id = entity.Id,
            Nome = entity.Nome,
        };
    }
    public static IEnumerable<GetTipoUsuariosResponse> MapToGetTipoUsuarios(this IEnumerable<TipoUsuarioEntity> response)
    {
        return response.Select(entity => entity.MapToGetTipoUsuarios());
    }
}