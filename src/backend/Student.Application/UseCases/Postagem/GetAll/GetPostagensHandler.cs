namespace Student.Application.UseCases.Postagem.GetAll;
public class GetPostagensHandler(IPostagemRepository repository)
{
    public async Task<PagedList<List<GetPostagensResponse>?>> GetHandler(PagedRequest request, CancellationToken token)
    {
        try
        {
            var response = await repository.GetAllAsync(request,token);

            if (response.Data == null || !response.Data.Any())
            {
                return new PagedList<List<GetPostagensResponse>?>(
                    new List<GetPostagensResponse>(), 
                    404, 
                    "Nenhum dado encontrado"
                    );
            }
            var result = response.Data.MapToGetPostagens().ToList();
            
            return new PagedList<List<GetPostagensResponse>?>(
                result, 
                200, 
                "Dados encontrados"
                );
        }
        catch (Exception ex)
        {
            return new PagedList<List<GetPostagensResponse>?>(
                null, 
                500, 
                $"Erro ao manupular a operação (GET ALL). Erro: {ex.Message}"
                );
        }
    }
}
