namespace Student.Domain.Entities;
public class UsuarioEntity: EntityBase, IAgragateRoot
{
    public string Nome { get; private set; } = null!;
    public string Email { get; private set; } = null!;
    public bool IsAdmin { get; private set; }
    public byte[] PasswordHash { get; private set; } = null!;
    public byte[] PasswordSalt { get; private set; } = null!;

    [JsonConstructor]
    public UsuarioEntity(){}

    public UsuarioEntity(int id, string nome, string email)
    {
        DomainValidationException.When(id < 0, "O Id do Usuário deve ser positivo");
        Id = id;
        ValidationDomain(nome, email);
    }
    public UsuarioEntity(string nome, string email)
    {
        ValidationDomain(nome, email);
    }

    public void SetAdmin(bool isAdmin)
    {
        IsAdmin = isAdmin;
    }
    public void UpdatePassword(byte[] passwordHash, byte[] passwordSalt)
    {
        PasswordHash = passwordHash;
        PasswordSalt = passwordSalt;
    }
    public void ValidationDomain(string nome, string email)
    {
        DomainValidationException.When(string.IsNullOrEmpty(nome), "Nome é obrigatório");
        DomainValidationException.When(string.IsNullOrEmpty(email), "Email é obrigatório");
        DomainValidationException.When(nome.Length > 250, "O Nome não pode ultrapassar de 200 caracteres");
        DomainValidationException.When(email.Length > 200, "O Nome não pode ultrapassar de 200 caracteres");

        Nome = nome;
        Email = email;
        IsAdmin = false;
    }
}