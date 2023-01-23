using System.Diagnostics.CodeAnalysis;

namespace CustomerManagement.Infrastructure.Extensions
{
    [ExcludeFromCodeCoverage]
    public static class MiddlewareExtensions
    {
        public static void ConfigureAppSettings(this IServiceCollection services, IConfiguration configuration)
        {
            services.Configure<AppSettings>(configuration.GetSection("AppSettings"));
        }
    }
}
