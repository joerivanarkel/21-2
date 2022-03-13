using Microsoft.Extensions.Configuration;

namespace Blazor
{

    public class DatabaseConnection
    {
        public static string Get()
        {
            var config = new ConfigurationBuilder()
                .SetBasePath(Path.GetDirectoryName(System.AppContext.BaseDirectory))
                .AddJsonFile("appsettings.json")
                .Build();
            return config.GetConnectionString("DefaultConnection");
        }
    }
}