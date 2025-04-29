namespace Student.Application.MethodExtensions.Postagem;
public static class SearchPostagemExtensions
{
    public static SearchPostagemResponse MapToSearchPostagem(this PostagemEntity entity)
    {
        return new SearchPostagemResponse
        {
            Id = entity.Id,
            Titulo = entity.Titulo,
            Data = entity.Data,
            Imagem = entity.Imagem,
            CategoriaId = entity.CategoriaId
        };
    }
    public static IEnumerable<SearchPostagemResponse> MapToSearchPostagem(this IEnumerable<PostagemEntity> response)
    {
        return response.Select(entity => entity.MapToSearchPostagem());
    }
}
