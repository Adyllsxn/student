namespace Student.Presentation.Core.Extensions.Architecture;
public static class ExternalLayersExtensions
{
    public static void AddExternalLayersExtensions(this WebApplicationBuilder builder)
    {
        builder.Services.AddApplicationDI();
        builder.Services.AddInfrastructureDI(builder.Configuration);
    }
}
