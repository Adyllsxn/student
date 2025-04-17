namespace Student.Application.MethodExtensions.Categoria;
public static class CreateCategoriaExtensions
{
    public static CategoriaEntity MapToCreateCategoria(this CreateCategoriaCommand command)
    {
        return new CategoriaEntity
        (
            command.Nome
        );
    }
    
    public static CreateCategoriaResponse MapToCreateCategorias (this CategoriaEntity entity)
    {
        return new CreateCategoriaResponse
        {
            Id = entity.Id,
            Nome = entity.Nome
        };
    }
    public static IEnumerable<CreateCategoriaResponse> MapToCreateCategorias(this IEnumerable<CategoriaEntity> dto)
    {
        return dto.Select(entity => entity.MapToCreateCategorias());
    }
}
