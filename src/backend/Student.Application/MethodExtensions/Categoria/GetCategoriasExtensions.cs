namespace Student.Application.MethodExtensions.Categoria;
public static class GetCategoriasExtensions
{
    public static GetCategoriasResponse MapToGetCategorias (this CategoriaEntity entity)
    {
        return new GetCategoriasResponse
        {
            Id = entity.Id,
            Nome = entity.Nome
        };
    }
    public static IEnumerable<GetCategoriasResponse> MapToGetCategorias(this IEnumerable<CategoriaEntity> response)
    {
        return response.Select(entity => entity.MapToGetCategorias());
    }
}
