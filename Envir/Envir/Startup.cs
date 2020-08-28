using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Envir.Models;
using Envir.Services;
using Microsoft.Extensions.Options;
<<<<<<< HEAD
using Microsoft.AspNetCore.Cors;

=======
>>>>>>> origin/Jacob

namespace Envir
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
           
            services.Configure<SkynetDatabaseSettings>(
              Configuration.GetSection(nameof(SkynetDatabaseSettings)));

            services.AddSingleton<ISkynetDatabaseSettings>(sp =>
           sp.GetRequiredService<IOptions<SkynetDatabaseSettings>>().Value);

            services.AddSingleton<UserService>();

<<<<<<< HEAD
            services.AddCors(options =>
            {
                options.AddPolicy("skynetpolicy", builder =>
                {
                    builder.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod();
                });
            });

            services.AddControllers();

=======
            services.AddControllers();

            services.AddCors();

>>>>>>> origin/Jacob
            services.AddMvc(MvcOptions => MvcOptions.EnableEndpointRouting = false);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app)
        {
<<<<<<< HEAD
            app.UseCors(builder =>
            {
                builder.WithOrigins("http://localhost:4200");
            });
=======
            app.UseCors(builder => builder
                .AllowAnyOrigin()
                .AllowAnyMethod()
                .AllowAnyHeader());
>>>>>>> origin/Jacob

            app.UseMvc();
        }
    }
}
