namespace Student.Application.Abstractions.Resposnse;
public record UsuarioResponse
{
    public int Id { get; set; }
    public string Nome { get; set; } = null!;
    public string Email { get; set; } = null!;
}
