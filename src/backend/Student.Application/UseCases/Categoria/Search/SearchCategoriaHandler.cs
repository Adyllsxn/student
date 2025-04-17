namespace Student.Application.UseCases.Categoria.Search;
public class SearchCategoriaHandler(ICategoriaRepository repository)
{
    public async Task<Result<List<SearchCategoriaResponse>>> SearchHendler(SearchCategoriaCommand command, CancellationToken token)
    {
        try
        {
            if(command.Nome == null)
            {
                return new Result<List<SearchCategoriaResponse>>(
                    null, 
                    400, 
                    "Parâmetro não deve estar vazio."
                    );
            }
            var response = await repository.SearchAsync(x => x.Nome.Contains(command.Nome),string.Empty,token);

            if (response.Data == null || !response.Data.Any())
            {
                return new Result<List<SearchCategoriaResponse>>(
                    null, 
                    404, 
                    "Nenhum dado encontrado"
                    );
            }
            var result = response.Data.MapToSearchCategoria().ToList();
            
            return new Result<List<SearchCategoriaResponse>>(
                result, 
                200, 
                "Dados encontrados"
                );
        }
        catch (Exception ex)
        {
            return new Result<List<SearchCategoriaResponse>>(
                null, 
                500, 
                $"Erro ao manipular a operação (SEARCH). Erro: {ex.Message}"
                );
        }
    }
}
