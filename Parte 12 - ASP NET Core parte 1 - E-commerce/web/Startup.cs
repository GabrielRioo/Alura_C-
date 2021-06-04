using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace Parte_12___ASP_NET_Core_parte_1___E_commerce
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services) // adicionar serviços a aplicacao, banco de dados, log, monitoramento...
        {
            //services.AddTransient<ICatalogo, Catalogo>(); // serviço temporario, gera instancia cada vez q é chamado
            //services.AddTransient<IRelatorio, Relatorio>();

            //services.AddScoped<ICatalogo, Catalogo>(); // a cada requisição gera apenas uma instancia
            //services.AddScoped<IRelatorio, Relatorio>();

            var catalogo = new Catalogo();
            services.AddSingleton<ICatalogo>(new Catalogo()); // instnacia unica ao longo de toda aplicacao. São os mesmos para todas as requisições
            services.AddSingleton<IRelatorio>(new Relatorio(catalogo));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, IServiceProvider serviceProvider) // local onde vai utilizar os serviços adicionados acima 
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            ICatalogo catalogo = serviceProvider.GetService<ICatalogo>();
            IRelatorio relatorio = serviceProvider.GetService<IRelatorio>();

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapGet("/", async context =>
                {
                    await relatorio.Imprimir(context);
                });
            });
        }
    }
}
