namespace Student.Application.UseCases.Postagem.GetFile;
public record GetFilePostagemCommand
{
    [Required(ErrorMessage = "Número do ID é obrigatório")]
    public int Id { get; set; }
}
