namespace Student.Application.UseCases.Usuario.Create;
public record CreateUsuarioCommand
{   
    [Required( ErrorMessage = "Nome é obrigatório")]
    [MaxLength(200, ErrorMessage = "O Nome não pode ultrapassar de 200 caracteres")]
    public string Nome { get; set; } = null!;

    [Required( ErrorMessage = " Email é obrigatório")]
    [MaxLength(200, ErrorMessage = "Email não pode ultrapassar de 200 caracteres")]
    [EmailAddress()]
    public string Email { get; set; } = null!;
}
