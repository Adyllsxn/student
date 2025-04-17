namespace Student.Application.Abstractions.DI.Architecture;
public static class UseCaseDI
{
    public static void AddUseCaseDI (this IServiceCollection services)
    {
        #region </Categoria>
            services.AddScoped<CreateCategoriaHendler>();
            services.AddScoped<DeleteCategoriaHandler>();
            services.AddScoped<GetCategoriasHandler>();
            services.AddScoped<GetCategoriaByIdHandler>();
            services.AddScoped<SearchCategoriaHandler>();
            services.AddScoped<UpdateCategoriaHandler>();
        #endregion
    }
}
