namespace IoC.Testing.Core.CharManipulationModule
{
    public class CharManipulatorService
    {
        private readonly string _prefix;
        public CharManipulatorService(string prefix)
        {
            _prefix = prefix;
        }

        public string CapitalCase(string word)
        {
            return word.ToUpper();
        }

        public string LowerCase(string word)
        {
            return word.ToLower();
        }

        public string Add3ACharsInTheEnd(string word)
        {
            var subService = new CharAdderSubService();
            var finalWord = subService.AddAInTheEnd(word, 3);
            return $"{_prefix}{finalWord}";
        }
    }
}