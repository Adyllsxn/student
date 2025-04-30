namespace Student.Application.UseCases.Postagem.GetFile;
public record GetFilePostagemCommand
{
    [Required]
    public int Id { get; set; }
}
