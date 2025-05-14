namespace Student.Infrastructure.Context.Mappings;
public class TipoUsuarioMapping : IEntityTypeConfiguration<TipoUsuarioEntity>
{
    public void Configure(EntityTypeBuilder<TipoUsuarioEntity> builder)
    {
        builder.ToTable("Tbl_TipoUsuario");
        builder.HasKey(x => x.Id);
        builder.Property(x => x.Nome).
                IsRequired(true).
                HasMaxLength(50).
                HasColumnType("NVARCHAR");
        builder.HasData(
            new TipoUsuarioEntity(1, "Adm"),
            new TipoUsuarioEntity(2, "Comum")
        );
    }
}
