namespace Student.Application.MethodExtensions.Categoria;
public static class GetCategoriaByIdExtensions
{
    public static GetCAtegoriaByIdResponse MapToGetCategoriaById (this CategoriaEntity entity)
    {
        return new GetCAtegoriaByIdResponse
        {
            Id = entity.Id,
            Nome = entity.Nome
        };
    }
    public static IEnumerable<GetCAtegoriaByIdResponse> MapToGetCategoriaById(this IEnumerable<CategoriaEntity> response)
    {
        return response.Select(entity => entity.MapToGetCategoriaById());
    }
}
