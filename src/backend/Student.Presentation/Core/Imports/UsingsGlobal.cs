#region </System>
    global using System.Text.Json.Serialization;
#endregion

#region </Microsoft>
    global using Microsoft.AspNetCore.Mvc;
    global using Microsoft.OpenApi.Models;
#endregion

#region </Presentation>
    global using Student.Presentation.Core.Extensions;
    global using Student.Presentation.Core.Extensions.Architecture;
    global using Student.Presentation.Core.Configurations;
    global using Student.Presentation.Features.Postagem.Model;
#endregion

#region </Application>
    global using Student.Application.Abstractions.Interfaces;
    global using Student.Application.Abstractions.DI;
    global using Student.Application.UseCases.Categoria.Create;
    global using Student.Application.UseCases.Categoria.Delete;
    global using Student.Application.UseCases.Categoria.GetById;
    global using Student.Application.UseCases.Categoria.Search;
    global using Student.Application.UseCases.Categoria.Update;
    global using Student.Application.UseCases.Postagem.Create;
    global using Student.Application.UseCases.Postagem.GetById;
    global using Student.Application.UseCases.Postagem.GetFile;
    global using Student.Application.UseCases.Postagem.GetAll;
    global using Student.Application.UseCases.Postagem.Delete;
    global using Student.Application.UseCases.Postagem.Search;
    global using Student.Application.UseCases.Postagem.Update;
#endregion

#region </Infrastructure>
    global using Student.Infrastructure.Abstractions.DI;
#endregion