using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using Bramf.AspNet;
using Bramf;

namespace MasterServer.Server
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)

                // Configure Bramf
                .UseBramf(configure =>
                {
                    configure.AddFileLogger();
                    configure.AddDefaultServices();
                })
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
