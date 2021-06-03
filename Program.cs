using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;

namespace TodoApi
{
    // Last build version: #{Build.DefinitionName}# - #{Build.Buildnumber}#
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
