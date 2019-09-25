using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;

namespace ADSBackend
{
    public class Program
    {
        public static void Main(string[] args)
        {
            BuildWebHost(args).Run();
        }

        public static IWebHost BuildWebHost(string[] args)
        {
            var configuration = new ConfigurationBuilder().AddEnvironmentVariables().Build();

            return WebHost.CreateDefaultBuilder(args)
                          .UseConfiguration(configuration)
                          .UseStartup<Startup>()
                          .Build();
        }
    }
}
