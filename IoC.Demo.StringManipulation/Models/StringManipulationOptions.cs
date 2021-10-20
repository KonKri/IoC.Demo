namespace IoC.Demo.StringManipulation.Models
{
    /// <summary>
    /// Refers to the options configured when injecting the String Manipulation service.
    /// </summary>
    public class StringManipulationOptions
    {
        #pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        
        public string Prefix { get; set; }

        public string Suffix { get; set; }

        #pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
    }
}