namespace Student.Application.UseCases.Postagem.Create;
public record CreatePostagemCommand
{
    [Required(ErrorMessage = "O Título é obrigatório")]
    [MaxLength(50, ErrorMessage = "Título deve ter no máximo 50 caracteres.")]
    public string Titulo { get; set; } = null!;

    [JsonIgnore]
    public DateTime Data { get; set; } = DateTime.UtcNow;

    [Required(ErrorMessage = "Imagem é obrigatório")]
    [MinLength(1, ErrorMessage = "Imagem deve ter no mínimo 1 caractere.")]
    public string Imagem { get; set; } = null!;

    [Required(ErrorMessage = "ID da categoria deve ser maior que zero.")]
    public int CategoriaId { get; set; }
}
