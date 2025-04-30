namespace Student.Application.UseCases.Postagem.GetById;
public record GetPostagemByIdCommand
{
    [Required]
    public int Id { get; set; }
}
