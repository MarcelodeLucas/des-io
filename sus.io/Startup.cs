using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Razor;
using Microsoft.AspNetCore.Routing.Patterns;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using sus.io.Data;

namespace sus.io
{
    public class Startup
    {
        
        public IConfiguration Configuration { get; }

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration; 

        }
        
        public void ConfigureServices(IServiceCollection services)
        {
            services.Configure<RazorViewEngineOptions>(options =>
            {
                options.AreaViewLocationFormats.Clear();
                options.AreaViewLocationFormats.Add("/Modulos/{2}/Views/{1}/{0}.cshtml");
                options.AreaViewLocationFormats.Add("/MyAreas/{2}/Views/Shared/{0}.cshtml");
                options.AreaViewLocationFormats.Add("/Views/Shared/{0}.cshtml");
            });


            services.AddDbContext<MeuDBcontext>(optionsAction: options => options.UseSqlServer(Configuration.GetConnectionString(name:"MeuDBcontext")));

            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);


            services.AddTransient<IPedidoRepository, PedidoRepository>();
        }


        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseStaticFiles();

            app.UseMvc(routes =>
            {
                routes.MapRoute(name:"default",template:"{controller=Home}/{action=Index}/{id?}");
                //routes.MapRoute(name:"areas", template: "{area:exists}/{controller=Home}/{action=Index}");

              
                routes.MapAreaRoute(name: "AreaVendas",areaName:"Produtos" ,template: "Produtos/{controller=Cadastro}/{action=Index}/{id?}");
                routes.MapAreaRoute(name: "AreaProdutos", areaName: "Vendas", template: "Vendas/{controller=Pedidos}/{action=Index}/{id?}");

            });
        }
    }
}
