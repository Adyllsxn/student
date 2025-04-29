namespace Student.Application.UseCases.Postagem.Search;
public class SearchPostagemHandler(IPostagemRepository repository)
{
    public async Task<Result<List<SearchPostagemResponse>>> SearchHendler(SearchPostagemCommand command, CancellationToken token)
    {
        try
        {
            if(command.Titulo == null)
            {
                return new Result<List<SearchPostagemResponse>>(
                    null, 
                    400, 
                    "Parâmetro não deve estar vazio."
                    );
            }
            var response = await repository.SearchAsync(x => x.Titulo.Contains(command.Titulo),string.Empty,token);

            if (response.Data == null || !response.Data.Any())
            {
                return new Result<List<SearchPostagemResponse>>(
                    null, 
                    404, 
                    "Nenhum dado encontrado"
                    );
            }
            var result = response.Data.MapToSearchPostagem().ToList();
            
            return new Result<List<SearchPostagemResponse>>(
                result, 
                200, 
                "Dados encontrados"
                );
        }
        catch (Exception ex)
        {
            return new Result<List<SearchPostagemResponse>>(
                null, 
                500, 
                $"Erro ao manipular a operação (SEARCH). Erro: {ex.Message}"
                );
        }
    }
}
