namespace Student.Domain.Abstractions.Authentication;
public interface IAuthenticationIdentity
{
    Task<bool> AuthenticateAsync(string email, string senha);
    Task<bool> UserExistAsync(string email);
    public string GenerateTokenAsync(int id, string email);
}
