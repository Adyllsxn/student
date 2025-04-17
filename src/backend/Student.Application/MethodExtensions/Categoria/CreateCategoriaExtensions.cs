namespace Student.Application.MethodExtensions.Categoria;
public static class CreateCategoriaExtensions
{
    public static CategoriaEntity MapToCategoriaEntity(this CreateCategoriaCommand command)
    {
        return new CategoriaEntity
        (
            command.Nome
        );
    }
    
    public static CreateCategoriaResponse MapToCreateCategoria (this CategoriaEntity entity)
    {
        return new CreateCategoriaResponse
        {
            Id = entity.Id,
            Nome = entity.Nome
        };
    }
    public static IEnumerable<CreateCategoriaResponse> MapToCreateCategoria(this IEnumerable<CategoriaEntity> response)
    {
        return response.Select(entity => entity.MapToCreateCategoria());
    }
}
