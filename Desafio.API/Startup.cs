using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Desafio.API.Contexto;
using Desafio.Repositorio.Abstrato.Interfaces;
using Desafio.Repositorio.EF.Implementacao;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;

namespace Desafio.API
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            var connectionString = Configuration.GetConnectionString("DesafioWebDb");
            var d = services.AddDbContext<DesafioDbApiContexto>(x => x.UseSqlServer(connectionString));
            services.AddScoped<DbContext, DesafioDbApiContexto>();

            services.AddScoped<IUsuarioRepositorio, UsuarioRepositorio>();
            services.AddScoped<ITelefoneRepositorio, TelefoneRepositorio>();
            services.AddScoped<IEnderecoRepositorio, EnderecoRepositorio>();

            services.AddMvc()
                .SetCompatibilityVersion(CompatibilityVersion.Version_2_2)
                .AddJsonOptions(options => { options.SerializerSettings.ReferenceLoopHandling = ReferenceLoopHandling.Ignore; });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, DesafioDbApiContexto desafioDbApiContexto)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            desafioDbApiContexto.EnsureSeedDataForContext();

            app.UseHttpsRedirection();
            app.UseMvc();
        }
    }
}
