using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Connections;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace ControleEstoque
{
    public class Startup
    {
        public IConfiguration Configuration{get;}

        public Startup(IConfiguration configuration){
            Configuration = configuration;
        }
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews().AddRazorRuntimeCompilation();
            services.AddDbContext<EstoqueWebContext>(options=> options.UseSqlite(Configuration.GetConnectionString("EstoqueWebContext")));
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
          
                app.UseDeveloperExceptionPage();
            
            app.UseStaticFiles();
            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapDefaultControllerRoute();
            });
        }
    }
}
