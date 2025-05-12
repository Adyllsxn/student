namespace Student.Infrastructure.Context.Mappings;
public class UsuarioMapping : IEntityTypeConfiguration<UsuarioEntity>
{
    public void Configure(EntityTypeBuilder<UsuarioEntity> builder)
    {
        builder.ToTable("Tbl_Usuario");
        builder.HasKey(x => x.Id);
        builder.Property(x => x.Nome).
                IsRequired(true).
                HasMaxLength(200).
                HasColumnType("VARCHAR");
                
        builder.Property(x => x.Email).
                IsRequired(true).
                HasMaxLength(200).
                HasColumnType("VARCHAR");
    }
}
