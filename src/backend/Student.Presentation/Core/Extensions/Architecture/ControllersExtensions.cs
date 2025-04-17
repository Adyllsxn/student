namespace Student.Presentation.Core.Extensions.Architecture;
public static class ControllersExtensions
{
    public static void AddControllersExtensions(this WebApplicationBuilder builder)
    {
        builder.Services.AddControllers()
        .AddJsonOptions(options =>
        {
            options.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.Preserve;
        });

        builder.Services.AddEndpointsApiExplorer();
    }
}
