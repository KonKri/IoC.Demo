using IoC.Demo.StringManipulation.Models;
using IoC.Demo.StringManipulation.Services;
using Microsoft.Extensions.DependencyInjection;

namespace IoC.Demo.StringManipulation
{
    public static class StartUp
    {
        /// <summary>
        /// Add String Manipulation service to the existing service collection.
        /// </summary>
        /// <param name="services">Existing service collection.</param>
        /// <param name="configureOptions">Configure options to be applied on the service.</param>
        /// <returns></returns>
        public static IServiceCollection AddStringManipulation(this IServiceCollection services, Action<StringManipulationOptions> configureOptions)
        {
            // initialize options obj.
            StringManipulationOptions options = new();

            // apply the configuration the user provided upon injecting the service.
            configureOptions(options);

            // check if both properties are set and not "".
            if (string.IsNullOrWhiteSpace(options.Prefix) || string.IsNullOrWhiteSpace(options.Suffix))
                throw new StringManipulationException($"{nameof(StringManipulationOptions.Prefix)} and {nameof(StringManipulationOptions.Suffix)} must both be set." );

            // inject the service.
            services.AddSingleton<IStringManipulationService>(x => new StringManipulationService(options));

            return services;
        }
    }
}