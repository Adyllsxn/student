namespace Student.Application.MethodExtensions.TipoUsuario;
public static class SearchTipoUsuarioExtensions
{
    public static SearchTipoUsuarioResponse MapToSearchTipoUsuario (this TipoUsuarioEntity entity)
    {
        return new SearchTipoUsuarioResponse
        {
            Id = entity.Id,
            Nome = entity.Nome
        };
    }
    public static IEnumerable<SearchTipoUsuarioResponse> MapToSearchTipoUsuario(this IEnumerable<TipoUsuarioEntity> response)
    {
        return response.Select(entity => entity.MapToSearchTipoUsuario());
    }
}
