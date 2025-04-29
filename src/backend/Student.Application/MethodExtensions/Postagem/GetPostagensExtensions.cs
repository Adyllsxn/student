namespace Student.Application.MethodExtensions.Postagem;
public static class GetPostagensExtensions
{
    public static GetPostagensResponse MapToGetPostagens (this PostagemEntity entity)
    {
        return new GetPostagensResponse
        {
            Id = entity.Id,
            Titulo = entity.Titulo,
            Data = entity.Data,
            Imagem = entity.Imagem,
            CategoriaId = entity.CategoriaId
        };
    }
    public static IEnumerable<GetPostagensResponse> MapToGetPostagens(this IEnumerable<PostagemEntity> response)
    {
        return response.Select(entity => entity.MapToGetPostagens());
    }
}