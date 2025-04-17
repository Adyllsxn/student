namespace Student.Presentation.Core.Extensions.Architecture;
public static class CorsExtensions
{
    public static void AddCorsExtensions(this WebApplicationBuilder builder)
    {
        builder.Services.AddCors( x => x.AddPolicy(
            UrlConfigurations.CorsPolicyNames,
            policy => policy.
                    WithOrigins(UrlConfigurations.BackendUrl, UrlConfigurations.FrontendUrl).
                    WithHeaders().
                    AllowAnyMethod().
                    AllowCredentials()
        ));
    }

    public static void UseCorsExtensions(this WebApplication app)
    {
        app.UseCors(UrlConfigurations.CorsPolicyNames);
    }
}
