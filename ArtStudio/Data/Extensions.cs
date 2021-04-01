using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;


namespace ArtStudio.Data
{
    public static class Extensions
    {
        private static IConfiguration _configuration { get; set; }
        private static IWebHostEnvironment _environment { get; set; }
        public static void SetConfiguration(IConfiguration configuration) => _configuration = configuration;
        public static IConfiguration GetConfiguration() => _configuration;
        public static IWebHostEnvironment GetEnvironment() => _environment;
        public static void SetEnvironment(IWebHostEnvironment env) => _environment = env;


        public static string SafeSubstring(this string fullString, int symbolLimit)
        {
            if (fullString != null && symbolLimit <= fullString.Length)
            {
                fullString = string.Concat(fullString.Substring(0, symbolLimit), "...");
            }
            return fullString;
        }
    }
}
