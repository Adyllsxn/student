namespace Student.Application.UseCases.Postagem.Search;
public record SearchPostagemCommand
{
    [Required(ErrorMessage = "O Título é obrigatório")]
    [MaxLength(50, ErrorMessage = "Título deve ter no máximo 50 caracteres.")]
    public string Titulo { get; set; } = null!;
}
