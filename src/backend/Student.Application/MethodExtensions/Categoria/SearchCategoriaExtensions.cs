namespace Student.Application.MethodExtensions.Categoria;
public static class SearchCategoriaExtensions
{
    public static SearchCategoriaResponse MapToSearchCategoria (this CategoriaEntity entity)
    {
        return new SearchCategoriaResponse
        {
            Id = entity.Id,
            Nome = entity.Nome
        };
    }
    public static IEnumerable<SearchCategoriaResponse> MapToSearchCategoria(this IEnumerable<CategoriaEntity> response)
    {
        return response.Select(entity => entity.MapToSearchCategoria());
    }
}
