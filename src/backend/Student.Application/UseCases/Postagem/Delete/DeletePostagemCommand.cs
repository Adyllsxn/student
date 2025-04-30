namespace Student.Application.UseCases.Postagem.Delete;
public record DeletePostagemCommand
{
    [Required]
    public int Id { get; set; }
}