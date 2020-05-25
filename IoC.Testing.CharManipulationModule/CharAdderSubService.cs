namespace IoC.Testing.CharManipulationModule
{
    internal class CharAdderSubService
    {
        internal string AddAInTheEnd(string word, int howManyCharsToAdd)
        {
            var wordToReturn = word;

            for (int i = 1; i <= howManyCharsToAdd; i++)
            {
                wordToReturn += "A";
            }

            return wordToReturn;
        }
    }
}