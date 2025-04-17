namespace Student.Application.MethodExtensions.Categoria;
public static class UpdateCategoriaExtensions
{
    public static CategoriaEntity MapToCategoriaEntity(this UpdateCategoriaCommand command)
        => new(command.Id, command.Nome);
    
    public static UpdateCategoriaResponse MapToUpdateCategoria (this CategoriaEntity entity)
    {
        return new UpdateCategoriaResponse
        {
            Id = entity.Id,
            Nome = entity.Nome
        };
    }
    public static IEnumerable<UpdateCategoriaResponse> MapToUpdateCategoria(this IEnumerable<CategoriaEntity> response)
    {
        return response.Select(entity => entity.MapToUpdateCategoria());
    }
}
