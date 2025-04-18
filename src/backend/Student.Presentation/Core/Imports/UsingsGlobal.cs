#region </System>
    global using System.Text.Json.Serialization;
#endregion

#region </Microsoft>
    global using Microsoft.AspNetCore.Mvc;
#endregion

#region </Presentation>
    global using Student.Presentation.Core.Extensions;
    global using Student.Presentation.Core.Extensions.Architecture;
    global using Student.Presentation.Core.Configurations;
#endregion

#region </Application>
    global using Student.Application.Abstractions.Interfaces;
    global using Student.Application.Abstractions.DI;
    global using Student.Application.UseCases.Categoria.Create;
    global using Student.Application.UseCases.Categoria.Delete;
    global using Student.Application.UseCases.Categoria.GetById;
    global using Student.Application.UseCases.Categoria.Search;
    global using Student.Application.UseCases.Categoria.Update;
#endregion

#region </Infrastructure>
    global using Student.Infrastructure.Abstractions.DI;
#endregion