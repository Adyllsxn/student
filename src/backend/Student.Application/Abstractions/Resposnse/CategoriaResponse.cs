namespace Student.Application.Abstractions.Resposnse;
public record CategoriaResponse
{
    public int Id { get; set; }
    public string Nome { get; set; } = null!;
}
