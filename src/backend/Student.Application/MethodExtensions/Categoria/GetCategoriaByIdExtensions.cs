namespace Student.Application.MethodExtensions.Categoria;
public static class GetCategoriaByIdExtensions
{
    public static GetCategoriaByIdResponse MapToGetCategoriaById (this CategoriaEntity entity)
    {
        return new GetCategoriaByIdResponse
        {
            Id = entity.Id,
            Nome = entity.Nome
        };
    }
    public static IEnumerable<GetCategoriaByIdResponse> MapToGetCategoriaById(this IEnumerable<CategoriaEntity> response)
    {
        return response.Select(entity => entity.MapToGetCategoriaById());
    }
}
