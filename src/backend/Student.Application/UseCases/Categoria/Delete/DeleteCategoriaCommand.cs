namespace Student.Application.UseCases.Categoria.Delete;
public record DeleteCategoriaCommand
{
    [Required]
    public int Id { get; set; }
}
