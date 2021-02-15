using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;
using WebApi;
using WebApi.Interfaces;
using WebApi.Repositories;

namespace rent.test
{
    public class StartUp
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddScoped<ICarRepository, CarRepository>();
            services.AddScoped<ICarRentRepository, CarRentRepository>();
            services.AddSingleton<SampleData>();
            /*
            services.AddIdentity<IdentityUser, IdentityRole>()
                .AddEntityFrameworkStores<db527Context>()
                .AddDefaultTokenProviders();
            */
        }
    }
}
