using Microsoft.Extensions.DependencyInjection;

namespace IoC.Testing.CharManipulationModule
{
    public class Startup
    {
        public static IServiceCollection AddCharManipulator(this IServiceCollection services)
        {
            services.AddScoped(s => new CharManipulatorService("thisIsAPrefix"));
            return services;
        }
    }
}