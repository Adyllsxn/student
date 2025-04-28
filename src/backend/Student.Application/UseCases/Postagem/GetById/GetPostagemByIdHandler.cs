namespace Student.Application.UseCases.Postagem.GetById;
public class GetPostagemByIdHandler(IPostagemRepository repository)
{
    public async Task<Result<GetPostagemByIdResponse>> GetByIdHandler(GetPostagemByIdCommand command, CancellationToken token)
    {
        try
        {
            if(command.Id <= 0)
            {
                return new Result<GetPostagemByIdResponse>(
                    null,
                    400,
                    "ID deve ser maior que zero."
                );
            }
            var response = await repository.GetByIdAsync(command.Id, token);
            if (response.Data == null)
            {
                return new Result<GetPostagemByIdResponse>(
                    null, 
                    404, 
                    "Nenhum dado encontrado"
                    );
            }
            var result = response.Data.MapToGetPostagemById();
            
            return new Result<GetPostagemByIdResponse>(
                result, 
                200, 
                "Dados encontrados"
                );
        }
        catch(Exception ex)
        {
            return new Result<GetPostagemByIdResponse>(
                null, 
                500, 
                $"Erro ao manipular a operação (GET BY ID). Erro: {ex.Message}"
                );
        }
    }
}
