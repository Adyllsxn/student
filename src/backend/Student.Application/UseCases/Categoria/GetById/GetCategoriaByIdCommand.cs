namespace Student.Application.UseCases.Categoria.GetById;
public class GetCategoriaByIdCommand
{
    [Required(ErrorMessage = "Número do ID é obrigatório")]
    public int Id { get; set; }
}
