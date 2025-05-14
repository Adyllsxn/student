#region </System>
    global using System.Linq.Expressions;
    global using System.IdentityModel.Tokens.Jwt;
    global using System.Security.Claims;
    global using System.Security.Cryptography;
    global using System.Text;
#endregion

#region </Microsoft>
    global using Microsoft.EntityFrameworkCore;
    global using Microsoft.EntityFrameworkCore.Metadata.Builders;
    global using Microsoft.Extensions.DependencyInjection;
    global using Microsoft.Extensions.Configuration;
    global using Microsoft.IdentityModel.Tokens;
#endregion

#region </Infrastructure>
    global using Student.Infrastructure.Context;
    global using Student.Infrastructure.Abstractions.DI;
    global using Student.Infrastructure.Abstractions.Identity;
    global using Student.Infrastructure.Repositories;
#endregion

#region </Domain>
    global using Student.Domain.Entities;
    global using Student.Domain.Abstractions.Interfaces;
    global using Student.Domain.Abstractions.Shared;
    global using Student.Domain.Abstractions.Pagination;
    global using Student.Domain.Abstractions.Authentication;
#endregion