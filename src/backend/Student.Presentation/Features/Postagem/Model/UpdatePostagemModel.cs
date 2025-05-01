namespace Student.Presentation.Features.Postagem.Model;
public class UpdatePostagemModel
{
    public int Id { get; set; }
    public string Titulo { get; set; } = null!;
    public IFormFile Imagem { get; set; } = null!;
    public int CategoriaId { get; set; }
}
