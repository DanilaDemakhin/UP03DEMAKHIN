namespace pr5_3
{
    internal class Filter
    {
        static void Main(string[] args)
        {
            DigitFilter stringLetters = new DigitFilter();
            Console.WriteLine(stringLetters.Execute("Ла1мб2ерт, Л35амб1е2рт, хре5н мор12ж7овый, Ламб321ерт, Ла67мберт, вре12дный5..."));
            LetterFilter stringDigits = new LetterFilter();
            Console.WriteLine(stringDigits.Execute("В5от хо3л2ер6а…"));
            Console.ReadKey(true);
        }
    }
    interface IFilter
    {
        string Execute(string textLine);
    }
    class DigitFilter : IFilter
    {
        public string Execute(string textline)
        {
            string str = "";
            char[] symbols = { ' ', ',', ':', ';', '-', '"', '(', ')', '.', '!', '?' };
            for (int i = 0; i < textline.Length; i++)
            {
                if (char.IsLetter(textline[i]) || Array.IndexOf(symbols, textline[i]) >= 0)
                {
                    str += textline[i];
                }
            }
            return str;
        }
    }
    class LetterFilter : IFilter
    {
        public string Execute(string textline)
        {
            string str = "";
            for (int i = 0; i < textline.Length; i++)
            {
                if (char.IsDigit(textline[i]))
                {
                    str += textline[i];
                }
            }
            return str;
        }
    }
}