namespace Student.Infrastructure.Repositories;
public class CategoriaRepository(AppDbContext context) : ICategoriaRepository
{
    #region </Create>
        public async Task<Result<CategoriaEntity>> CreateAsync(CategoriaEntity entity, CancellationToken token)
        {
            try
            {
                if(entity == null)
                {
                    return new Result<CategoriaEntity>(
                        null, 
                        400, 
                        "Parâmetros não podem estar vazio."
                        );
                }
                await context.Categorias.AddAsync(entity, token);
                return new Result<CategoriaEntity>(
                    entity, 
                    201, 
                    "Operação executada com sucesso."
                    );
            }
            catch (Exception ex)
            {
                return new Result<CategoriaEntity>(
                    null, 
                    500, 
                    $"Erro ao executar a operação (CRIAR). Erro {ex.Message}."
                    );
            }
        }
    #endregion

    #region </Delete>
        public async Task<Result<bool>> DeleteAsync(int entityId, CancellationToken token)
        {
            try
            {
                if (entityId <= 0)
                {
                    return new Result<bool>(
                        false, 
                        400, 
                        "ID deve ser maior que zero."
                        );
                }
                var response = await context.Categorias.FindAsync(entityId, token);
                if (response == null)
                {
                    return new Result<bool>(
                        false, 
                        404, 
                        "ID não encontrado."
                        );
                }
                context.Categorias.Remove(response);
                return new Result<bool>(true, 200, "Operação executada com sucesso.");
            }
            catch (Exception ex)
            {
                return new Result<bool>(
                    false, 
                    500, 
                    $"Erro ao executar a operação (DELETAR). Erro {ex.Message}."
                    );
            }
        }
    #endregion

    #region </GetAll>
        public async Task<Result<List<CategoriaEntity>?>> GetAllAsync(CancellationToken token)
        {
            try
            {
                var response = await context.Categorias.AsNoTracking().ToListAsync(token);
                if (response == null || response.Count == 0)
                {
                    return new Result<List<CategoriaEntity>?>(
                        null, 
                        404, 
                        "Nenhum dado encontrado."
                        );
                }

                return new Result<List<CategoriaEntity>?>(
                    response, 
                    200, 
                    "Dados.");
            }
            catch (Exception ex)
            {
                return new Result<List<CategoriaEntity>?>(
                    null, 
                    500, 
                    $"Erro ao executar a operação (GET ALL). Erro {ex.Message}."
                    );
            }
        }
    #endregion

    #region </GetById>
        public async Task<Result<CategoriaEntity?>> GetByIdAsync(int entityId, CancellationToken token)
        {
            try
            {
                if(entityId <= 0)
                {
                    return new Result<CategoriaEntity?>(
                        null, 
                        400, 
                        "ID deve ser maior que zero."
                        );
                }
                var response = await context.Categorias.FindAsync(entityId, token);
                if(response == null)
                {
                    return new Result<CategoriaEntity?>(
                        null, 
                        404, 
                        "ID não encontrado."
                        );
                }
                return new Result<CategoriaEntity?>(
                    response, 
                    200, 
                    "Dados encontrado."
                    );
            }
            catch (Exception ex)
            {
                return new Result<CategoriaEntity?>(
                    null, 
                    500, 
                    $"Erro ao executar a operação (GET BY ID). Erro {ex.Message}."
                    );
            }
        }
    #endregion

    #region </Search>
        public async Task<Result<List<CategoriaEntity>?>> SearchAsync(Expression<Func<CategoriaEntity, bool>> expression, string entity, CancellationToken token)
        {
            try
            {
                if(entity == null)
                {
                    return new Result<List<CategoriaEntity>?>(
                        null, 
                        400, 
                        "Parâmetros não podem estar vazio."
                        );
                }
                var response = await context.Categorias.Where(expression).ToListAsync(token);
                if(response == null || response.Count == 0)
                {
                    return new Result<List<CategoriaEntity>?>(
                        null, 
                        404, 
                        "Nenhum dado encontrado."
                        );
                }

                return new Result<List<CategoriaEntity>?>(
                    response, 
                    200, 
                    "Dados encontrado."
                    );
            }
            catch (Exception ex)
            {
                return new Result<List<CategoriaEntity>?>(
                    null, 
                    500, 
                    $"Erro ao executar a operação (SEARCH). Erro {ex.Message}."
                    );
            }
        }
    #endregion

    #region </Update>
        public async Task<Result<CategoriaEntity>> UpdateAsync(CategoriaEntity entity, CancellationToken token)
        {
            try
            {
                if(entity == null)
                {
                    return new Result<CategoriaEntity>(
                        null, 
                        400, 
                        "Parâmetros não podem estar vazio."
                        );
                }
                var response = await context.Categorias.FindAsync(entity.Id);
                if(response == null)
                {
                    return new Result<CategoriaEntity>(
                        null, 
                        404, 
                        "ID não encontrado."
                        );
                }
                context.Entry(response).CurrentValues.SetValues(entity);
                return new Result<CategoriaEntity>(
                    response, 
                    200, 
                    "Operação executada com sucesso."
                    );
            }
            catch (Exception ex)
            {
                return new Result<CategoriaEntity>(
                    null, 
                    500, 
                    $"Erro ao executar a operação (UPDATE). Erro {ex.Message}."
                    );
            }
        }
    #endregion
}