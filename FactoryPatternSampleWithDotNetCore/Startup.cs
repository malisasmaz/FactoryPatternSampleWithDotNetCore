using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FactoryPatternSample.Common.Abstraction.Account.Open;
using FactoryPatternSample.Common.Account.Open.Common;
using FactoryPatternSample.Common.Account.Open.TL;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace FactoryPatternSampleWithDotNetCore {
    public class Startup {
        public Startup(IConfiguration configuration) {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services) {
            services.AddScoped<IOpenAccountFactory, OpenAccountFactory>();
            services.AddScoped<IOpenAccountProvider, OpenTLAccountProvider>();
            services.AddScoped<IOpenAccountProvider, OpenUSDAccountProvider>();

            services.AddControllers();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env) {
            if (env.IsDevelopment()) {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints => {
                endpoints.MapControllers();
            });
        }
    }
}
