using Microsoft.Extensions.DependencyInjection;
using System;

namespace IoC.Testing.Core.CharManipulationModule
{
    public static class Startup
    {
        //public static IServiceCollection AddCharManipulator(this IServiceCollection services)
        //{
        //    services.AddScoped(s => new CharManipulatorService("thisIsAPrefix"));
        //    return services;
        //}

        public static IServiceCollection AddCharManipulator(this IServiceCollection services, Action<Options> options)
        {
            var optionsToUse = new Options();
            options(optionsToUse);
            services.AddScoped(s => new CharManipulatorService(optionsToUse.prefix));
            return services;
        }
    }
}