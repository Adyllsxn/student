namespace Student.Application.UseCases.TipoUsuario.GetById;
public record GetTipoUsuarioByIdCommand
{
    [Required(ErrorMessage = "ID é obrigatório")]
    public int Id { get; set; }
}
