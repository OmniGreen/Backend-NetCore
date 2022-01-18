using System;
using Uzx.Infra.CrossCutting.Identity.Models;
using Uzx.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Uzx.Services.Api.Configurations
{
    public static class DatabaseSetup
    {
        public static void AddDatabaseSetup(this IServiceCollection services, IConfiguration configuration)
        {
            if (services == null) throw new ArgumentNullException(nameof(services));

            // services.AddDbContext<ApplicationDbContext>(options =>
            //     options.UseNpgsql(configuration.GetConnectionString("DefaultConnection")));

            services.AddDbContext<UzxBaseDbContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("UzenixDatabase")));

            //services.AddDbContext<UzxBaseDbContext>(options =>
            //    options.UseNpgsql(configuration.GetConnectionString("UzenixDatabase")));
        }
    }
}