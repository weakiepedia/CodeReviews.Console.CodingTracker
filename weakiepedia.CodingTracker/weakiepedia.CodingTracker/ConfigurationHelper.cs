using Microsoft.Extensions.Configuration;

namespace weakiepedia.CodingTracker;

internal static class ConfigurationHelper
{
    private static IConfiguration configuration;

    static ConfigurationHelper()
    {
        configuration = new ConfigurationBuilder().SetBasePath("E:\\TheCSharpAcademy\\weakiepedia.CodingTracker\\weakiepedia.CodingTracker").AddJsonFile("config.json").Build();
    }
    
    internal static string GetConnectionString()
    {
        return configuration["connectionString"];
    }
}