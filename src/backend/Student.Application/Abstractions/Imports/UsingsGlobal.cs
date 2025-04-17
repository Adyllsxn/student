#region <System>
    global using System.ComponentModel.DataAnnotations;
#endregion

#region </Microsoft>
    global using Microsoft.Extensions.DependencyInjection;
#endregion

#region </Application>
    global using Student.Application.Abstractions.DI.Architecture;
    global using Student.Application.Abstractions.Interfaces;
    global using Student.Application.Services;
    global using Student.Application.MethodExtensions.Categoria;
    global using Student.Application.UseCases.Categoria.Create;    
    global using Student.Application.UseCases.Categoria.GetAll;
#endregion

#region </Domain>
    global using Student.Domain.Abstractions.Interfaces;
    global using Student.Domain.Entities;
    global using Student.Domain.Abstractions.Shared;
#endregion