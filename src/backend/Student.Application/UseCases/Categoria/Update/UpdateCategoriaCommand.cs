namespace Student.Application.UseCases.Categoria.Update;
public record UpdateCategoriaCommand
{
    public int Id { get; set; }

    [Required]
    [StringLength(50, ErrorMessage = "O Nome deve ter 50 no máximo caracteres")]
    public string Nome { get; set; } = null!;
}
