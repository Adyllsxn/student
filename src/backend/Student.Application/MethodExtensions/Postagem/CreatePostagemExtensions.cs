namespace Student.Application.MethodExtensions.Postagem;
public static class CreatePostagemExtensions
{
    public static PostagemEntity MapToPostagemEntity(this CreatePostagemCommand command)
    {
        return new PostagemEntity
        (
            command.Titulo,
            command.Data = DateTime.UtcNow,
            command.Imagem,
            command.CategoriaId
        );
    }
    public static CreatePostagemResponse MapToCreatePostagem (this PostagemEntity entity)
    {
        return new CreatePostagemResponse
        {
            Id = entity.Id,
            Titulo = entity.Titulo,
            Data = entity.Data,
            Imagem = entity.Imagem,
            CategoriaId = entity.CategoriaId
        };
    }
    public static IEnumerable<CreatePostagemResponse> MapToCreatePostagem(this IEnumerable<PostagemEntity> response)
    {
        return response.Select(entity => entity.MapToCreatePostagem());
    }
}
