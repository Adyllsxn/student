namespace Student.Presentation.Core.Extensions.Architecture;
public static class SwaggerExtensions
{
    public static void AddSwaggerExtensions(this WebApplicationBuilder builder)
    {
        builder.Services.AddSwaggerGen(
            c =>
            {
                #region </SwaggerDoc>
                    c.SwaggerDoc("v1", new OpenApiInfo{
                        Title = "Student.API",
                        Version = "v1",
                        Description = "STUDENT é uma plataforma web para compartilhamento de conteúdos acadêmicos, permitindo a publicação de resumos, links, vídeos e PDFs, com interação por comentários, curtidas e favoritos. A plataforma é voltada para estudantes e professores, promovendo a troca de conhecimento e facilitando o acesso a materiais de estudo."
                    });
                #endregion

                #region </SecurityDefinition>
                    c.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme{
                        Name = "Authorization",
                        Type = SecuritySchemeType.ApiKey,
                        BearerFormat = "JWT",
                        In = ParameterLocation.Header,
                        Description = "Insiera o token para se autenticar"
                    });
                #endregion

                #region </SecurityRequirement>
                    c.AddSecurityRequirement(new OpenApiSecurityRequirement()
                    {
                        {
                            new OpenApiSecurityScheme()
                            {
                                Reference = new OpenApiReference()
                                {
                                    Type = ReferenceType.SecurityScheme,
                                    Id = "Bearer"
                                }
                            },
                            new string []{}
                        }
                    });
                #endregion
            }
        );
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
