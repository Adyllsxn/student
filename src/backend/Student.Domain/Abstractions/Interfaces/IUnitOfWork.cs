namespace Student.Domain.Abstractions.Interfaces;
public interface IUnitOfWork
{
    Task CommitAsync();
}
