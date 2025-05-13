namespace Student.Application.UseCases.Categoria.Search;
public record SearchCategoriaCommand
{
    [Required(ErrorMessage = "Nome é obrigatório")]
    [StringLength(60, ErrorMessage = "O Nome deve ter 60 no máximo caracteres")]
    [DataType(DataType.Text)]
    public string Nome { get; set; } = null!;
}
