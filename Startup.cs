using System;
using system.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace API_Usuario {
    
    public class Startup {

        public Startup(IConfiguration configuration) {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services) {
            
            services.AddDbContext<UsuarioDbContext>(options => options.UseSqlServer(Configuration.GetConnectionString("DefaultConnections"))); 
            services.AddMvc();
        
        }

        public void Configure(IApplicationBuilder app, IHostingEnviroment env) {

            if(env.IsDevelopment()) {
                app.UseDeveloperExceptionPage();
            }

            app.UseMvc();
        }
    }
}