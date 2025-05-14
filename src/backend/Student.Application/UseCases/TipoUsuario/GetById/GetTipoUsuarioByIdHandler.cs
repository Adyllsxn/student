namespace Student.Application.UseCases.TipoUsuario.GetById;
public class GetTipoUsuarioByIdHandler(ITipoUsuarioRepository repository)
{
    public async Task<Result<GetTipoUsuarioByIdResponse>> GetByIdHandler(GetTipoUsuarioByIdCommand command, CancellationToken token)
    {
        try
        {
            if(command.Id <= 0)
            {
                return new Result<GetTipoUsuarioByIdResponse>(
                    null,
                    400,
                    "ID deve ser maior que zero."
                );
            }
            var response = await repository.GetByIdAsync(command.Id, token);
            if (response.Data == null)
            {
                return new Result<GetTipoUsuarioByIdResponse>(
                    null, 
                    404, 
                    "Nenhum dado encontrado"
                    );
            }
            var result = response.Data.MapToGetTipoUsuarioById();
            
            return new Result<GetTipoUsuarioByIdResponse>(
                result, 
                200, 
                "Dados encontrados"
                );
        }
        catch(Exception ex)
        {
            return new Result<GetTipoUsuarioByIdResponse>(
                null, 
                500, 
                $"Erro ao manipular a operação (GET BY ID). Erro: {ex.Message}"
                );
        }
    }
}
