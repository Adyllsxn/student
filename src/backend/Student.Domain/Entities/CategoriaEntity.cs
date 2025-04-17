namespace Student.Domain.Entities;
public sealed class CategoriaEntity: EntityBase, IAgragateRoot
{
    public string Nome { get; private set; } = null!;

    [JsonConstructor]
    public CategoriaEntity(){}
    public CategoriaEntity(int id, string nome)
    {
        ValidationException.When(id <= 0 , "ID deve ser maior que zero.");
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
        ValidationException.When(string.IsNullOrWhiteSpace(nome), "Nome é obrigatório.");
        ValidationException.When(nome.Length >= 50, "Nome deve ter no máximo 60 caracteres.");

        Nome = nome;
    }
}
