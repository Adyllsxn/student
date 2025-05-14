namespace Student.Application.UseCases.TipoUsuario.GetAll;
public class GetTipoUsuariosHandler(ITipoUsuarioRepository repository)
{
    public async Task<PagedList<List<GetTipoUsuariosResponse>?>> GetHandler(GetTipoUsuariosCommand command, CancellationToken token)
    {
        try
        {
            var response = await repository.GetAllAsync(command,token);

            if (response.Data == null || !response.Data.Any())
            {
                return new PagedList<List<GetTipoUsuariosResponse>?>(
                    new List<GetTipoUsuariosResponse>(), 
                    404, 
                    "Nenhum dado encontrado"
                    );
            }
            var result = response.Data.MapToGetTipoUsuarios().ToList();
            
            return new PagedList<List<GetTipoUsuariosResponse>?>(
                result, 
                200, 
                "Dados encontrados"
                );
        }
        catch (Exception ex)
        {
            return new PagedList<List<GetTipoUsuariosResponse>?>(
                null, 
                500, 
                $"Erro ao manupular a operação (GET ALL). Erro: {ex.Message}"
                );
        }
    }
}
