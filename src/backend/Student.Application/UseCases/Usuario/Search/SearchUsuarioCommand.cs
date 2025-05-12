namespace Student.Application.UseCases.Usuario.Search;
public record SearchUsuarioCommand
{
    [Required]
    public string Nome { get; set; } = null!;
}
