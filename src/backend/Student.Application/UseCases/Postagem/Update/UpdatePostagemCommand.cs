namespace Student.Application.UseCases.Postagem.Update;
public record UpdatePostagemCommand
{
    [Required(ErrorMessage = "Número do ID é obrigatório")]
    public int Id { get; set; }

    [Required(ErrorMessage = "O Título é obrigatório")]
    [MaxLength(50, ErrorMessage = "Título deve ter no máximo 50 caracteres.")]
    [DataType(DataType.Text)]
    public string Titulo { get; set; } = null!;

    [JsonIgnore]
    public DateTime Data { get; set; } = DateTime.UtcNow;

    [Required(ErrorMessage = "Imagem é obrigatório")]
    [MinLength(1, ErrorMessage = "Imagem deve ter no mínimo 1 caractere.")]
    [DataType(DataType.ImageUrl)]
    public string Imagem { get; set; } = null!;

    [Required(ErrorMessage = "ID da categoria deve ser maior que zero.")]
    public int CategoriaId { get; set; }
}