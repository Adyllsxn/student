namespace Student.Infrastructure.Abstractions.DI;
public static class InfrastructureDI
{
    public static void AddInfrastructureDI (this IServiceCollection services, IConfiguration configuration)
    {
        #region </Repositories>
            services.AddScoped<IAuthenticationIdentity, AuthenticationIdentity>();
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped<ICategoriaRepository, CategoriaRepository>();
            services.AddScoped<IPostagemRepository, PostagemRepository>();
            services.AddScoped<IDashboardRepository, DashboardRepository>();
            services.AddScoped<IUsuarioRepository, UsuarioRepository>();
        #endregion

        #region </DbConnection>
            var connectionDb = configuration.GetConnectionString(ConnectionDbStringContext.ConnectionDbSqlServer);

            services.AddDbContext<AppDbContext>(opt =>{
                opt.UseSqlServer(connectionDb,
                migration => migration.MigrationsAssembly(typeof(AppDbContext).Assembly.FullName));
            });
        #endregion
    }
}
