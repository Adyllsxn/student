namespace Student.Infrastructure.Context.Mappings;
public class CategoriaMapping : IEntityTypeConfiguration<CategoriaEntity>
{
    public void Configure(EntityTypeBuilder<CategoriaEntity> builder)
    {
        builder.ToTable("Tbl_Categoria");
        builder.HasKey(x => x.Id);
        builder.Property(x => x.Nome).
                IsRequired(true).
                HasMaxLength(50).
                HasColumnType("NVARCHAR");
        builder.HasData(
            new CategoriaEntity(1, "Programação"),
            new CategoriaEntity(2, "Design")
        );
    }
}
