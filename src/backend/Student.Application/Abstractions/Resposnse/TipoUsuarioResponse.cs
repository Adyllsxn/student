namespace Student.Application.Abstractions.Resposnse;
public record TipoUsuarioResponse
{
    public int Id { get; set; }
    public string Nome { get; set; } = null!;
}
