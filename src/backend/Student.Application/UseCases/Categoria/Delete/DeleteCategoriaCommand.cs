namespace Student.Application.UseCases.Categoria.Delete;
public record DeleteCategoriaCommand
{
    [Required(ErrorMessage = "ID é obrigatório")]
    public int Id { get; set; }
}
