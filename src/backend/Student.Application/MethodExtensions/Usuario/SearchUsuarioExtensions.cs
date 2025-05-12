namespace Student.Application.MethodExtensions.Usuario;
public static class SearchUsuarioExtensions
{
    public static SearchUsuarioResponse MapToSearchUsuario(this UsuarioEntity entity)
    {
        return new SearchUsuarioResponse
        {
            Id = entity.Id,
            Nome = entity.Nome,
            Email = entity.Email
        };
    }
    public static IEnumerable<SearchUsuarioResponse> MapToSearchUsuario(this IEnumerable<UsuarioEntity> response)
    {
        return response.Select(entity => entity.MapToSearchUsuario());
    }
}
