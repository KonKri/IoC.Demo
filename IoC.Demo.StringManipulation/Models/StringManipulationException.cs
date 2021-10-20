namespace IoC.Demo.StringManipulation.Models
{
    /// <summary>
    /// Refers to Exceptions regarding StringManipulation.
    /// </summary>
    public class StringManipulationException : Exception
    {
        public StringManipulationException(string? message) : base(message)
        {
        }
    }
}
