using Test.Domain.Interfaces;
using Test.Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Infrastructure
{
    public static class DependencyInjection
    {
        //private static readonly IConfiguration _configuration;

        public static IServiceCollection AddRepository(this IServiceCollection services)
        {
            //services.AddTransient<IProductRepository, ProductRepository>();
            //services.AddTransient<IUnitOfWork, UnitOfWork>();
            services.AddTransient<IUserRepo, UserRepo>();

            //services.AddMemoryCache();

            //services.AddDbContext<ApplicationContext>(opt => opt
            //    .UseSqlServer("Server=DESKTOP-UUBJ14C\\SQLEXPRESS; Database=OrderDb;Trusted_Connection=True;"));
            //services.AddDbContext<ApplicationContext>(options => options.UseOracle(_configuration.GetConnectionString("OracleConn")));
            return services;
        }

        //public static IServiceCollection AddServices(this IServiceCollection services)
        //{
        //    return services
        //        .AddScoped();
        //}
    }
}
