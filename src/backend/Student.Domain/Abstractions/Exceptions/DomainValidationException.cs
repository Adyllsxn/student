namespace Student.Domain.Abstractions.Exceptions;
public class DomainValidationException : Exception
{
    public DomainValidationException(string message) : base(message){}
    public static void When (bool condition, string message)
    {
        if(condition)
        {
            throw new DomainValidationException(message);
        }
    }
}
