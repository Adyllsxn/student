namespace Student.Application.UseCases.Postagem.GetFile;
public class GetFilePostagemHandler(IPostagemRepository repository)
{
    public async Task<Result<GetFilePostagemResponse>> GetFileHandler(GetFilePostagemCommand command, CancellationToken token)
    {
        try
        {
            if(command.Id <= 0)
            {
                return new Result<GetFilePostagemResponse>(
                    null,
                    400,
                    "ID deve ser maior que zero."
                );
            }
            var response = await repository.GetFileAsync(command.Id, token);
            if (response.Data == null)
            {
                return new Result<GetFilePostagemResponse>(
                    null, 
                    404, 
                    "Nenhum dado encontrado"
                    );
            }
            var result = response.Data.MapToGetFilePostagem();
            
            return new Result<GetFilePostagemResponse>(
                result, 
                200, 
                "Dados encontrados"
                );
        }
        catch(Exception ex)
        {
            return new Result<GetFilePostagemResponse>(
                null, 
                500, 
                $"Erro ao manipular a operação (GET FILE). Erro: {ex.Message}"
                );
        }
    }
}
