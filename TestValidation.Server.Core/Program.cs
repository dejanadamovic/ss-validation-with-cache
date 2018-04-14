using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Funq;
using ServiceStack;
using ServiceStack.Validation;

namespace TestValidation.Server.Core
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var host = new WebHostBuilder()
                .UseKestrel()
                .UseContentRoot(Directory.GetCurrentDirectory())
                .UseStartup<Startup>()
                .UseUrls("http://localhost:8088/")
                .Build();

            host.Run();
        }
    }

    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            app.UseServiceStack(new AppHost());

            app.Run(context =>
            {
                context.Response.Redirect("/metadata");
                return Task.FromResult(0);
            });
        }
    }

    public class AppHost : AppHostBase
    {
        public AppHost()
            : base("TestValidation.Server.Core", typeof(HelloService).Assembly) { }

        public override void Configure(Container container)
        {
            Plugins.Add(new ValidationFeature());
        }
    }
}