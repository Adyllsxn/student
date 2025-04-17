namespace Student.Presentation.Core.Extensions;
public static class AppExtensions
{
    public static void UseArchitectureExtensions(this WebApplication app)
    {
        app.UseCorsExtensions();
        app.UseSweggerExtensions();
        app.UseHttpsRedirection();
        app.UseAuthorization();
        app.MapControllers();
        app.Run();
    }
}
