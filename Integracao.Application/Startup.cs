using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Contmatic.Integracao.Domain.Interfaces.Repositories;
using Contmatic.Integracao.Infrastructure.CrossCutting;
using Contmatic.Integracao.Infrastructure.Data.Repositories;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Microsoft.Extensions.PlatformAbstractions;
using Swashbuckle.AspNetCore.Swagger;

namespace Integracao.Application
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
            services.AddMvc();
            services.AddAutoMapper();
            
            services.AddTransient<IEmailService, EmailService>();
            services.AddScoped<IConviteRepository, ConviteRepository>();
            
           
            // Configurando o serviço de documentação do Swagger
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1",
                    new Info
                    {
                        Title = "API de Integração",
                        Version = "v1",
                        Description = "Afim de ter um relacionamento da empresa do Contador com a Empresa do Cliente, usuária do Ponto Eletrônico, e depois disso fazer integrações automáticas entre os sistemas definimos que a forma de comunicação entre as partes será realizada mediante a utilização de uma Chave de Integração.",
                        Contact = new Contact
                        {
                            Name = "Vinícius Alexandre Saraiva Silva",
                            Url = "vinicius.net.br"
                        }
                    });

                string caminhoAplicacao =
                    PlatformServices.Default.Application.ApplicationBasePath;
                string nomeAplicacao =
                    PlatformServices.Default.Application.ApplicationName;
                
                string caminhoXmlDoc = System.IO.Path.Combine(caminhoAplicacao, "api-convite.xml");

                c.IncludeXmlComments(caminhoXmlDoc);
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseMvc();

             // Ativando middlewares para uso do Swagger
            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json",
                    "Conversor de Temperaturas");
            });
        }
    }
}
