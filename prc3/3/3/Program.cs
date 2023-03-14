namespace pr2_3
{
    internal class Pr
    {
        static void Main(string[] args)
        {

            ШифрЦезаря myShifr = new ШифрЦезаря();
            myShifr.SetShifr("жкжцфэрё", -6);
            Console.WriteLine(myShifr.GetShifr());
            myShifr.SetShifr("храз это на самом деле Харитон захарыч", 1);
            Console.WriteLine(myShifr.GetShifr());
            Console.ReadKey(true);
        }
        class ШифрЦезаря
        {
            private string strShifr;
            private int shift;
            public string GetShifr()
            {
                return strShifr;
            }
            public void SetShifr(string code, int shift)
            {
                this.strShifr = EncryptStr(code, shift);
                this.shift = shift;
            }
            private string EncryptStr(string code, int shift)
            {
                char[] букавы = { 'а', 'б', 'в', 'г', 'д', 'е', 'ё', 'ж', 'з', 'и', 'й', 'к', 'л', 'м', 'н', 'о', 'п', 'р', 'с', 'т', 'у', 'ф', 'х', 'ц', 'ч', 'ш', 'щ', 'ъ', 'ы', 'ь', 'э', 'ю', 'я' };
                char l;
                int ind;
                string stringShifr = "";
                for (int i = 0; i < code.Length; i++)
                {

                    l = code[i];
                    if (l == ' ')
                    {
                        stringShifr += l;
                        continue;
                    }
                    ind = Array.IndexOf(букавы, l);
                    ind += shift;
                    if (ind > 32)
                    {
                        ind -= 33;
                    }
                    else if (ind < 0)
                    {
                        ind += 33;
                    }
                    stringShifr += букавы[ind];
                }
                return stringShifr;
            }
        }
    }
}