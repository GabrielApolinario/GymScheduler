using GymScheduler.Domain.Interfaces;
using GymScheduler.Infrastructure.Contexts;
using GymScheduler.Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymScheduler.Infrastructure
{
    public static class ServiceExtensions
    {
        public static void ConfigureInfrastructureApp(this IServiceCollection services, IConfiguration configuration)
        {
            var connectionString = configuration.GetConnectionString("AppContext");

            services.AddDbContext<ExerciseContext>(d => d.UseSqlite(connectionString));

            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped<IExerciseRepository, ExerciseRepository>();
        }
    }
}