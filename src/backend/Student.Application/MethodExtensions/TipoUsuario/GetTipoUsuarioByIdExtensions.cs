namespace Student.Application.MethodExtensions.TipoUsuario;
public static class GetTipoUsuarioByIdExtensions
{
    public static GetTipoUsuarioByIdResponse MapToGetTipoUsuarioById (this TipoUsuarioEntity entity)
    {
        return new GetTipoUsuarioByIdResponse
        {
            Id = entity.Id,
            Nome = entity.Nome
        };
    }
    public static IEnumerable<GetTipoUsuarioByIdResponse> MapToGetTipoUsuarioById(this IEnumerable<TipoUsuarioEntity> response)
    {
        return response.Select(entity => entity.MapToGetTipoUsuarioById());
    }
}
