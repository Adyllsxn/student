#region </System>
    global using System.Text.Json.Serialization;
    global using System.Text;
#endregion

#region </Microsoft>
    global using Microsoft.AspNetCore.Mvc;
    global using Microsoft.OpenApi.Models;
    global using Microsoft.AspNetCore.Authentication.JwtBearer;
    global using Microsoft.IdentityModel.Tokens;
    global using Microsoft.AspNetCore.Authorization;
#endregion

#region </Presentation>
    global using Student.Presentation.Core.Extensions;
    global using Student.Presentation.Core.Extensions.Architecture;
    global using Student.Presentation.Core.Configurations;
    global using Student.Presentation.Features.Postagem.Model;
    global using Student.Presentation.Features.Usuario.Model;
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

    global using Student.Application.UseCases.Usuario.Create;
    global using Student.Application.UseCases.Usuario.Delete;
    global using Student.Application.UseCases.Usuario.GetAll;
    global using Student.Application.UseCases.Usuario.GetById;
    global using Student.Application.UseCases.Usuario.Search;
    global using Student.Application.UseCases.Usuario.Update;
#endregion

#region </Infrastructure>
    global using Student.Infrastructure.Abstractions.DI;
#endregion

#region </Domain>
    global using Student.Domain.Abstractions.Authentication;
#endregion