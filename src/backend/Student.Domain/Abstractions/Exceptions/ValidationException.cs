namespace Student.Domain.Abstractions.Exceptions;
public class ValidationException : Exception
{
    public ValidationException(string message) : base(message){}
    public static void When (bool condition, string message)
    {
        if(condition)
        {
            throw new ValidationException(message);
        }
    }
}
