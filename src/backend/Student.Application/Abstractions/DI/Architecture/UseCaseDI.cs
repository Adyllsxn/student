namespace Student.Application.Abstractions.DI.Architecture;
public static class UseCaseDI
{
    public static void AddUseCaseDI (this IServiceCollection services)
    {
        #region </Dashboard>
            services.AddScoped<GetDashboardHandler>();
        #endregion

        #region </TipoUsuario>
            services.AddScoped<CreateTipoUsuarioHandler>();
            services.AddScoped<DeleteTipoUsuarioHandler>();
            services.AddScoped<GetTipoUsuariosHandler>();
            services.AddScoped<GetTipoUsuarioByIdHandler>();
            services.AddScoped<SearchTipoUsuarioHandler>();
            services.AddScoped<UpdateTipoUsuarioHandler>();
        #endregion

        #region </Usuario>
            services.AddScoped<CreateUsuarioHandler>();
            services.AddScoped<DeleteUsuarioHandler>();
            services.AddScoped<GetUsuariosHandler>();
            services.AddScoped<GetUsuarioByIdHandler>();
            services.AddScoped<SearchUsuarioHandler>();
            services.AddScoped<UpdateUsuarioHandler>();
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
            services.AddScoped<UpdatePostagemHandler>();
        #endregion
    }
}
