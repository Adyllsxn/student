namespace Student.Presentation.Core.Extensions;
public static class BuildExtensions
{
    public static void AddArchitectureExtensions(this WebApplicationBuilder builder)
    {
        builder.AddControllersExtensions();
        builder.AddSwaggerExtensions();
        builder.AddJwtBearerExtensions(builder.Configuration);
        builder.AddCorsExtensions();
        builder.AddExternalLayersExtensions();
    }
}
