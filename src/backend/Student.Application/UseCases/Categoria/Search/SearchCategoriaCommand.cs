namespace Student.Application.UseCases.Categoria.Search;
public record SearchCategoriaCommand
{
    [Required(ErrorMessage = "Nome é obrigatório")]
    [DataType(DataType.Text)]
    public string Nome { get; set; } = null!;
}
