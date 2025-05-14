namespace Student.Application.MethodExtensions.Usuario;
public static class GetUsuarioByIdExtensions
{
    public static GetUsuarioByIdResponse MapToGetUsuarioById (this UsuarioEntity entity)
    {
        return new GetUsuarioByIdResponse
        {
            Id = entity.Id,
            Nome = entity.Nome,
            Email = entity.Email,
            TipoUsuarioId = entity.TipoUsuarioId
        };
    }
    public static IEnumerable<GetUsuarioByIdResponse> MapToGetUsuarioById(this IEnumerable<UsuarioEntity> response)
    {
        return response.Select(entity => entity.MapToGetUsuarioById());
    }
}
