using IoC.Demo.StringManipulation.Models;

namespace IoC.Demo.StringManipulation.Services
{
    internal class StringManipulationService : IStringManipulationService
    {
        private readonly StringManipulationOptions _options;

        internal StringManipulationService(StringManipulationOptions options)
        {
            _options = options;
        }

        public void ManipulateStr(ref string str)
        {
            str = $"{_options.Prefix}{str}{_options.Suffix}";
        }
    }
}
