namespace Student.Application.UseCases.Postagem.Delete;
public record DeletePostagemCommand
{
    [Required(ErrorMessage = "Número do ID é obrigatório")]
    public int Id { get; set; }
}