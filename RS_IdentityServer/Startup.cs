using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using RS_IdentityServer.Configuration;

namespace RS_IdentityServer
{
    public class Startup
    {
        public IConfiguration Config { get; }
        public Startup(IConfiguration configuration)
        {
            Config = configuration;
        }
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddIdentityServer()
                .AddInMemoryClients(Clients.GetClients())
                .AddInMemoryApiResources(Resources.GetApiResources())
                .AddInMemoryApiScopes(Resources.GetApiScopes())
                .AddSigningCredential(LoadCertificate.LoadCertuficateFromStore(Config.GetValue<string>("CertificateThumbprint")));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapGet("/", async context =>
                {
                    await context.Response.WriteAsync("Hello World!");
                });
            });
        }
    }
}
