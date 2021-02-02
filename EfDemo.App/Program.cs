using Microsoft.Extensions.Configuration;

namespace EfDemo.App
{
    class Program
    {
        static void Main(string[] args)
        {
            var connectionString = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json")
                .Build().GetConnectionString("Default");

            // var context = new DemoContext(connectionString);
        }
    }
}