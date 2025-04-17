namespace Student.Application.UseCases.Categoria.GetAll;
public sealed class GetCategoriasHandler(ICategoriaRepository repository)
{
    public async Task<Result<List<GetCategoriasResponse>>> GetHandler(CancellationToken token)
    {
        try
        {
            var response = await repository.GetAllAsync(token);

            if (response.Data == null || !response.Data.Any())
            {
                return new Result<List<GetCategoriasResponse>>(
                    new List<GetCategoriasResponse>(), 
                    404, 
                    "Nenhum dado encontrado"
                    );
            }
            var result = response.Data.MapToGetCategorias().ToList();
            
            return new Result<List<GetCategoriasResponse>>(
                result, 
                200, 
                "Dados encontrados"
                );
        }
        catch (Exception ex)
        {
            return new Result<List<GetCategoriasResponse>>(
                null, 
                500, 
                $"Erro ao manupular a operação (GET ALL). Erro: {ex.Message}"
                );
        }
    }
}
