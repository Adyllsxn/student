namespace Student.Application.UseCases.Categoria.Create;
public record CreateCategoriaCommand
{
    [Required]
    [StringLength(60, ErrorMessage = "O Nome deve ter 60 no máximo caracteres")]
    public string Nome { get; set; } = null!;
}