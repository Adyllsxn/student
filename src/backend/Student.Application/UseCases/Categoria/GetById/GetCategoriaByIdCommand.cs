namespace Student.Application.UseCases.Categoria.GetById;
public class GetCategoriaByIdCommand
{
    [Required(ErrorMessage = "ID é obrigatório")]
    public int Id { get; set; }
}
