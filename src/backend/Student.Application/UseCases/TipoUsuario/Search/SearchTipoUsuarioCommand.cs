namespace Student.Application.UseCases.TipoUsuario.Search;
public record SearchTipoUsuarioCommand
{
    [Required(ErrorMessage = "Nome é obrigatório")]
    [DataType(DataType.Text)]
    public string Nome { get; set; } = null!;
}
