namespace Student.Infrastructure.Context;
public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
{
    public DbSet<CategoriaEntity> Categorias { get; set; } = null!;
    public DbSet<PostagemEntity> Postagens { get; set; } = null!;
    public DbSet<UsuarioEntity> Usuarios { get; set; } = null!;
    public DbSet<TipoUsuarioEntity> TipoUsuarios { get; set; } = null!;

    protected override void OnModelCreating(ModelBuilder modelBuilder) => modelBuilder.ApplyConfigurationsFromAssembly(typeof(InfrastructureDI).Assembly);
}
