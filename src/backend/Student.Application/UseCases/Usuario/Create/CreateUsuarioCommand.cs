using System.ComponentModel.DataAnnotations.Schema;

namespace Student.Application.UseCases.Usuario.Create;
public record CreateUsuarioCommand
{   
    [JsonIgnore]
    [Required(ErrorMessage = "ID é obrigatório")]
    public int Id { get; set; }

    [Required( ErrorMessage = "Nome é obrigatório")]
    [MaxLength(200, ErrorMessage = "O Nome não pode ultrapassar de 200 caracteres")]
    [DataType(DataType.Text)]
    public string Nome { get; set; } = null!;

    [Required( ErrorMessage = " Email é obrigatório")]
    [MaxLength(200, ErrorMessage = "Email não pode ultrapassar de 200 caracteres")]
    [DataType(DataType.EmailAddress)]
    public string Email { get; set; } = null!;

    [Required(ErrorMessage = "Password é obrigatório")]
    [MinLength(4, ErrorMessage = "A senha deve conter no mínimo 4 caracteres.")]
    [DataType(DataType.Password)]
    [NotMapped]
    public string Password { get; set; } = null!;

    [JsonIgnore]
    [Required(ErrorMessage = "Tipo de usuário é obrigatório")]
    public int TipoUsuarioId { get; set; }
}
