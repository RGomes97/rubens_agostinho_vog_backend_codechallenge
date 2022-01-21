using Microsoft.Extensions.DependencyInjection;
using VogCodeChallenge.API.App.Domain.Repositories;
using VogCodeChallenge.API.App.Domain.Repositories.Implementation;
using VogCodeChallenge.API.App.Domain.Services;
using VogCodeChallenge.API.App.Domain.Services.Implementation;

namespace VogCodeChallenge.API.App.Infrastructure
{
    internal static class DependencyResolver
    {
        internal static void Configure(IServiceCollection services)
        {
            //Repositories
            services.AddSingleton<IEmployeeRepository, EmployeeRepository>();
            //Services
            services.AddSingleton<IEmployeeService, EmployeeService>();

        }
    }
}
