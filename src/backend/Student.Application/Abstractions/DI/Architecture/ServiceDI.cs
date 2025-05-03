namespace Student.Application.Abstractions.DI.Architecture;
public static class ServiceDI
{
    public static void AddServiceDI (this IServiceCollection services)
    {
        services.AddScoped<ICategoriaService, CategoriaService>();
        services.AddScoped<IPostagemService, PostagemService>();
        services.AddScoped<IDashboardService, DashboardService>();
        services.AddScoped<IUsuarioService, UsuarioService>();
        
    }
}
