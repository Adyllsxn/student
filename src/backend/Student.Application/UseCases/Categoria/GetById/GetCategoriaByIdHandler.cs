namespace Student.Application.UseCases.Categoria.GetById;
public class GetCategoriaByIdHandler(ICategoriaRepository repository)
{
    public async Task<Result<GetCAtegoriaByIdResponse>> GetByIdHandler(GetCategoriaByIdCommand command, CancellationToken token)
    {
        try
        {
            if(command.Id <= 0)
            {
                return new Result<GetCAtegoriaByIdResponse>(
                    null,
                    400,
                    "ID deve ser maior que zero."
                );
            }
            var response = await repository.GetByIdAsync(command.Id, token);
            if (response.Data == null)
            {
                return new Result<GetCAtegoriaByIdResponse>(
                    null, 
                    404, 
                    "Nenhum dado encontrado"
                    );
            }
            var result = response.Data.MapToGetCategoriaById();
            
            return new Result<GetCAtegoriaByIdResponse>(
                result, 
                200, 
                "Dados encontrados"
                );
        }
        catch(Exception ex)
        {
            return new Result<GetCAtegoriaByIdResponse>(
                null, 
                500, 
                $"Erro ao manipular a operação (GET BY ID). Erro: {ex.Message}"
                );
        }
    }
}
