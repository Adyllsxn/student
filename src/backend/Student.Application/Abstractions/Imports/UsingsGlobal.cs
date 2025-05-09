#region <System>
    global using System.ComponentModel.DataAnnotations;
    global using System.Text.Json.Serialization;
#endregion

#region </Microsoft>
    global using Microsoft.Extensions.DependencyInjection;
#endregion

#region </Application>
    global using Student.Application.Abstractions.DI.Architecture;
    global using Student.Application.Abstractions.Interfaces;
    global using Student.Application.Abstractions.Resposnse;
    global using Student.Application.Services;
    global using Student.Application.MethodExtensions.Categoria;
    global using Student.Application.MethodExtensions.Postagem;
    global using Student.Application.MethodExtensions.Dashboard;
    global using Student.Application.UseCases.Dashboard;
    global using Student.Application.UseCases.Categoria.Create;    
    global using Student.Application.UseCases.Categoria.GetAll;
    global using Student.Application.UseCases.Categoria.Delete;
    global using Student.Application.UseCases.Categoria.GetById;
    global using Student.Application.UseCases.Categoria.Search;
    global using Student.Application.UseCases.Categoria.Update;
    global using Student.Application.UseCases.Usuario.Create;   
    global using Student.Application.UseCases.Usuario.GetAll;
    global using Student.Application.UseCases.Usuario.Delete;
    global using Student.Application.UseCases.Usuario.GetById;
    global using Student.Application.UseCases.Usuario.Search;
    global using Student.Application.UseCases.Usuario.Update;
    global using Student.Application.UseCases.Postagem.Create;
    global using Student.Application.UseCases.Postagem.GetFile;
    global using Student.Application.UseCases.Postagem.GetById;
    global using Student.Application.UseCases.Postagem.GetAll;
    global using Student.Application.UseCases.Postagem.Delete;
    global using Student.Application.UseCases.Postagem.Search;
    global using Student.Application.UseCases.Postagem.Update;
#endregion

#region </Domain>
    global using Student.Domain.Abstractions.Interfaces;
    global using Student.Domain.Abstractions.Shared;
    global using Student.Domain.Abstractions.Pagination;
    global using Student.Domain.Entities;
#endregion