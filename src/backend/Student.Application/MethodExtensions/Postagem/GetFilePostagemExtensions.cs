namespace Student.Application.MethodExtensions.Postagem;
public static class GetFilePostagemExtensions
{
    public static GetFilePostagemResponse MapToGetFilePostagem (this PostagemEntity entity)
    {
        return new GetFilePostagemResponse
        {
            Imagem = entity.Imagem
        };
    }
    public static IEnumerable<GetFilePostagemResponse> MapToGetFilePostagem(this IEnumerable<PostagemEntity> response)
    {
        return response.Select(entity => entity.MapToGetFilePostagem());
    }
}
