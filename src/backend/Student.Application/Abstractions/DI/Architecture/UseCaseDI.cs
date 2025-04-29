namespace Student.Application.Abstractions.DI.Architecture;
public static class UseCaseDI
{
    public static void AddUseCaseDI (this IServiceCollection services)
    {
        #region </Dashboard>
            services.AddScoped<GetDashboardHandler>();
        #endregion

        #region </Categoria>
            services.AddScoped<CreateCategoriaHendler>();
            services.AddScoped<DeleteCategoriaHandler>();
            services.AddScoped<GetCategoriasHandler>();
            services.AddScoped<GetCategoriaByIdHandler>();
            services.AddScoped<SearchCategoriaHandler>();
            services.AddScoped<UpdateCategoriaHandler>();
        #endregion

        #region </Postagem>
            services.AddScoped<CreatePostagemHandler>();
            services.AddScoped<GetFilePostagemHandler>();
            services.AddScoped<GetPostagemByIdHandler>();
            services.AddScoped<GetPostagensHandler>();
            services.AddScoped<DeletePostagemHandler>();
            services.AddScoped<SearchPostagemHandler>();
        #endregion
    }
}
