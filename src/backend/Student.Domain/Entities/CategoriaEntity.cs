namespace Student.Domain.Entities;
public sealed class CategoriaEntity: EntityBase, IAgragateRoot
{
    public string Nome { get; private set; } = null!;

    public ICollection<PostagemEntity> Postagens { get; set; } = new List<PostagemEntity>();

    [JsonConstructor]
    public CategoriaEntity(){}
    public CategoriaEntity(int id, string nome)
    {
        DomainValidationException.When(id <= 0 , "ID deve ser maior que zero.");
        Id = id;
        ValidationDomain(nome);
    }
    public CategoriaEntity(string nome)
    {
        ValidationDomain(nome);
    }
    public void Update(string nome)
    {
        ValidationDomain(nome);
    }
    public void ValidationDomain(string nome)
    {
        DomainValidationException.When(string.IsNullOrWhiteSpace(nome), "Nome é obrigatório.");
        DomainValidationException.When(nome.Length > 50, "Nome deve ter no máximo 50 caracteres.");

        Nome = nome;
    }
}
