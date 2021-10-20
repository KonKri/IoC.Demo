namespace IoC.Demo.StringManipulation.Services
{
    public interface IStringManipulationService
    {
        /// <summary>
        /// Manipulate existing string with the preconfigured prefix and suffix.
        /// </summary>
        /// <param name="str">string var to manipualate.</param>
        void ManipulateStr(ref string str);
    }
}