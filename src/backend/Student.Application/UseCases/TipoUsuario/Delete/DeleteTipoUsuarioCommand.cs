namespace Student.Application.UseCases.TipoUsuario.Delete;
public record DeleteTipoUsuarioCommand
{
    [Required(ErrorMessage = "ID é obrigatório")]
    public int Id { get; set; }
}
