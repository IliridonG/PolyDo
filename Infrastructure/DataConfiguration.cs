using Infrastructure.Data;
using Domain.Interfaces.TaskRepository;
using Infrastructure.Data.Repositories;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure
{
    public static class DataConfiguration
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services)
        {
            var connectionString = "Server=LEGION-5-IG;Database=PolyDo;Integrated Security=True;"; // Can be moved to appsettings.json
            services.AddDbContext<PolyDoContext>(options => options.UseSqlServer(connectionString));
            services.AddScoped<ITaskRepository, TaskRepository>();
            return services;
        }
    }
}
