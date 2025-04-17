namespace Student.Presentation.Core.Extensions.Architecture;
public static class ExternalLayersExtensions
{
    public static void AddExternalLayersExtensions(this WebApplicationBuilder builder)
    {
        builder.Services.AddInfrastructureDI(builder.Configuration);
        builder.Services.AddApplicationDI();
        
    }
}
