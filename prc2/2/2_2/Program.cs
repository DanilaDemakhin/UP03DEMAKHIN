namespace pr2_2
{
    class Num
    {
        internal class pr
        {
            static void Main(string[] args)
            {
                Num num = new Num();
                int chislo;
                for (int i = 1; i >= 0; i = num.GetNum(chislo) + 1)
                {
                    Console.WriteLine($"Бро, этот алгоритм просто пушка, введи число {i}");
                    chislo = Convert.ToInt32(Console.ReadLine());
                }
                Console.ReadKey(true);
            }
        }
        private int n = 0;
        public int GetNum(int number)
        {
            if (SetNum(number))
            {
                this.n = number;
            }
            else
            {
                this.n = 0;
            }
            return this.n;
        }
        private bool SetNum(int number)
        {
            if (number == this.n + 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}