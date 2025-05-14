namespace Student.Application.UseCases.Postagem.GetById;
public record GetPostagemByIdCommand
{
    [Required(ErrorMessage = "Número do ID é obrigatório")]
    public int Id { get; set; }
}
