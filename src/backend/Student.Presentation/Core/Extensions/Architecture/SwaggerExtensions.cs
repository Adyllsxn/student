namespace Student.Presentation.Core.Extensions.Architecture;
public static class SwaggerExtensions
{
    public static void AddSwaggerExtensions(this WebApplicationBuilder builder)
    {
        builder.Services.AddSwaggerGen();
    }

    public static void UseSweggerExtensions(this WebApplication app)
    {
        if(app.Environment.IsDevelopment())
        {
            app.UseSwagger();
            app.UseSwaggerUI();
        }
    }
}
