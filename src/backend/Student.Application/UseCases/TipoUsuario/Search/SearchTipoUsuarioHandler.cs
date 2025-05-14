namespace Student.Application.UseCases.TipoUsuario.Search;
public class SearchTipoUsuarioHandler(ITipoUsuarioRepository repository)
{
    public async Task<Result<List<SearchTipoUsuarioResponse>>> SearchHendler(SearchTipoUsuarioCommand command, CancellationToken token)
    {
        try
        {
            if(command.Nome == null)
            {
                return new Result<List<SearchTipoUsuarioResponse>>(
                    null, 
                    400, 
                    "Parâmetro não deve estar vazio."
                    );
            }
            var response = await repository.SearchAsync(x => x.Nome.Contains(command.Nome),string.Empty,token);

            if (response.Data == null || !response.Data.Any())
            {
                return new Result<List<SearchTipoUsuarioResponse>>(
                    null, 
                    404, 
                    "Nenhum dado encontrado"
                    );
            }
            var result = response.Data.MapToSearchTipoUsuario().ToList();
            
            return new Result<List<SearchTipoUsuarioResponse>>(
                result, 
                200, 
                "Dados encontrados"
                );
        }
        catch (Exception ex)
        {
            return new Result<List<SearchTipoUsuarioResponse>>(
                null, 
                500, 
                $"Erro ao manipular a operação (SEARCH). Erro: {ex.Message}"
                );
        }
    }
}
