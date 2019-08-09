using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;
using TesteConquest.Application;
using TesteConquest.Application.Interfaces;
using TesteConquest.Domain.Interfaces;
using TesteConquest.Domain.Services;
using TesteConquest.Infra.Data.Context;
using TesteConquest.Infra.Data.Repositories;

namespace TesteConquest.CrossCutting.Ioc
{
    public class NativeInjectorBootStrapper
    {
        public static void RegisterServices(IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<IAutorAppService, AutorAppService>();
            services.AddScoped<IAutorService, AutorService>();
            services.AddScoped<IAutorRepository, AutorRepository>();

            services.AddDbContext<ConquestContext>(options =>
            options.UseSqlServer(configuration.GetConnectionString("ConquestContext")));

            
            
            //services.AddDbContext<ConquestContext>(options =>
            //options.UseSqlServer(@"Server=EMILIO-NOTE; Database=TesteConquest; User Id=sa; Password=impacto; MultipleActiveResultSets=true; Connection Timeout=999;"));

        }
    }
}
