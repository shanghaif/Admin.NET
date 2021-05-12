using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;

namespace Admin.NET.Web.Entry
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .UseWindowsService() //支持 windows 系统服务 
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.Inject()
                              .UseStartup<Startup>()
                              .UseSerilogDefault();
                });
    }
}
