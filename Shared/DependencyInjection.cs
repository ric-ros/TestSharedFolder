using Microsoft.Extensions.DependencyInjection;
using MudBlazor.Services;
using Shared;
using TestSharedFolder.Shared.Services;

namespace TestSharedFolder.Shared
{
    static public class DependencyInjection
    {
        static public void AddSharedDependencies(this Microsoft.Extensions.DependencyInjection.IServiceCollection services)
        {
            services.AddScoped<WeatherForecastService>();
            services.AddScoped<ExampleJsInterop>();

            services.AddMudServices();
        }
    }
}
