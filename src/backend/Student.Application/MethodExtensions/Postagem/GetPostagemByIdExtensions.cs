namespace Student.Application.MethodExtensions.Postagem;
public static class GetPostagemByIdExtensions
{
    public static GetPostagemByIdResponse MapToGetPostagemById (this PostagemEntity entity)
    {
        return new GetPostagemByIdResponse
        {
            Id = entity.Id,
            Titulo = entity.Titulo,
            Data = entity.Data,
            Imagem = entity.Imagem,
            CategoriaId = entity.CategoriaId
        };
    }
    public static IEnumerable<GetPostagemByIdResponse> MapToGetPostagemById(this IEnumerable<PostagemEntity> response)
    {
        return response.Select(entity => entity.MapToGetPostagemById());
    }
}
