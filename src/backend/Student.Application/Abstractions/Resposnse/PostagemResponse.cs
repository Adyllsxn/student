namespace Student.Application.Abstractions.Resposnse;
public record PostagemResponse
{
    public int Id { get; set; }
    public string Titulo { get; set; } = null!;
    public DateTime Data { get; set; } = DateTime.UtcNow;
    public string Imagem { get; set; } = null!;
    public int CategoriaId { get; set; }
}
