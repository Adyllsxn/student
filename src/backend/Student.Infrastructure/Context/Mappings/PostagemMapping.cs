namespace Student.Infrastructure.Context.Mappings;
public class PostagemMapping : IEntityTypeConfiguration<PostagemEntity>
{
    public void Configure(EntityTypeBuilder<PostagemEntity> builder)
    {
        builder.ToTable("Tbl_Postagem");
        builder.HasKey(x => x.Id);
        builder.Property(x => x.Titulo).
                IsRequired(true).
                HasMaxLength(50).
                HasColumnType("NVARCHAR");
        builder.Property(x => x.Data).
                IsRequired(true);
        builder.Property(x => x.Imagem).
                IsRequired(true);
        builder.Property(x => x.CategoriaId).
                IsRequired(true);
        
        builder.HasOne(x => x.Categoria).WithMany(x => x.Postagens).HasForeignKey(x => x.CategoriaId).HasConstraintName("FK_CategoriaPostagem").OnDelete(DeleteBehavior.Cascade);
    }
}
