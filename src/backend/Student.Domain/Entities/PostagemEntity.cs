namespace Student.Domain.Entities;
public class PostagemEntity: EntityBase, IAgragateRoot
{
    public string Titulo { get; private set; } = null!;
    public DateTime Data { get; private set; } = DateTime.UtcNow;
    public string Imagem { get; private set; } = null!;
    public int CategoriaId { get; private set; }

    [JsonIgnore]
    public CategoriaEntity Categoria { get; private set; } = null!;

    [JsonConstructor]
    public PostagemEntity(){}

    public PostagemEntity(int id, string titulo, DateTime data, string imagem, int categoriaId)
    {
        DomainValidationException.When(id <= 0 , "ID deve ser maior que zero.");
        Id = id;
        ValidationDomain(titulo, data, imagem, categoriaId);
    }
    public PostagemEntity(string titulo, DateTime data, string imagem, int categoriaId)
    {
        ValidationDomain(titulo, data, imagem, categoriaId);
    }
    public void Update(string titulo, DateTime data, string imagem, int categoriaId)
    {
        ValidationDomain(titulo, data, imagem, categoriaId);
    }
    public void ValidationDomain(string titulo, DateTime data, string imagem, int categoriaId)
    {
        DomainValidationException.When(string.IsNullOrWhiteSpace(titulo), "Título é obrigatório.");
        DomainValidationException.When(titulo.Length >= 50, "Título deve ter no máximo 50 caracteres.");

        DomainValidationException.When(string.IsNullOrWhiteSpace(imagem), "Imagem é obrigatório.");
        DomainValidationException.When(imagem.Length < 1, "Imagem deve ter no mínimo 1 caractere.");

        DomainValidationException.When(categoriaId <= 0 , "ID da categoria deve ser maior que zero.");

        Titulo = titulo;
        Data = data;
        Imagem = imagem;
        CategoriaId = categoriaId;
    }
}