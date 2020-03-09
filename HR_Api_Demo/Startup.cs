using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
namespace HR_Api_Demo
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
            services.AddControllers();
            services.Configure<Moduleregister>(Configuration.GetSection("Moduleregister"));
            services.AddSingleton<NLog.ILogger>(NLog.LogManager.GetLogger("HR"));
            var config = Configuration.GetSection("Moduleregister");
            var conf = config.Get<Moduleregister>();
            foreach(var mod in conf.Module)
            {
               var asm= Assembly.LoadFrom(conf.SourceDir+mod.SourcePath);
                var typeInterface = asm.GetType(mod.Interface);
                var typeClass= asm.GetType(mod.ConcreteClass);
                services.AddScoped(typeInterface, typeClass);
            }

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
