namespace Student.Application.MethodExtensions.Postagem;
public static class UpdatePostagemExtensions
{
    public static PostagemEntity MapToPostagemEntity(this UpdatePostagemCommand command)
    {
        return new PostagemEntity
        (
            command.Id,
            command.Titulo,
            command.Data = DateTime.UtcNow,
            command.Imagem,
            command.CategoriaId
        );
    }
    
    public static UpdatePostagemResponse MapToUpdatePostagem (this PostagemEntity entity)
    {
        return new UpdatePostagemResponse
        {
            Id = entity.Id,
            Titulo = entity.Titulo,
            Data = entity.Data,
            Imagem = entity.Imagem,
            CategoriaId = entity.CategoriaId
        };
    }
    public static IEnumerable<UpdatePostagemResponse> MapToUpdatePostagem(this IEnumerable<PostagemEntity> response)
    {
        return response.Select(entity => entity.MapToUpdatePostagem());
    }
}
