#region </System>
    global using System.Linq.Expressions;
#endregion

#region </Microsoft>
    global using Microsoft.EntityFrameworkCore;
    global using Microsoft.EntityFrameworkCore.Metadata.Builders;
    global using Microsoft.Extensions.DependencyInjection;
    global using Microsoft.Extensions.Configuration;
#endregion

#region </Infrastructure>
    global using Student.Infrastructure.Context;
    global using Student.Infrastructure.Abstractions.DI;
    global using Student.Infrastructure.Repositories;
#endregion

#region </Domain>
    global using Student.Domain.Entities;
    global using Student.Domain.Abstractions.Interfaces;
    global using Student.Domain.Abstractions.Shared;
    global using Student.Domain.Abstractions.Pagination;
#endregion