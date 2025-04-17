namespace Student.Application.UseCases.Categoria.Delete;
public sealed record DeleteCategoriaCommand
{
    [Required]
    public int Id { get; set; }
}
