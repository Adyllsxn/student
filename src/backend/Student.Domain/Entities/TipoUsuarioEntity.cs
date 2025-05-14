namespace Student.Domain.Entities;
public class TipoUsuarioEntity: EntityBase, IAgragateRoot
{
    public string Nome { get; set; } = null!;
    public ICollection<UsuarioEntity> Usuarios { get; set; } = new List<UsuarioEntity>();

    [JsonConstructor]
    public TipoUsuarioEntity(){}
    public TipoUsuarioEntity(int id, string nome)
    {
        DomainValidationException.When(id <= 0 , "ID deve ser maior que zero.");
        Id = id;
        ValidationDomain(nome);
    }
    public TipoUsuarioEntity(string nome)
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
