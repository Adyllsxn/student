namespace Student.Application.UseCases.Categoria.Search;
public record SearchCategoriaResponse
{
    public int Id { get; set; }
    [Required]
    [StringLength(60, ErrorMessage = "O Nome deve ter 60 no máximo caracteres")]
    public string Nome { get; set; } = null!;
}
