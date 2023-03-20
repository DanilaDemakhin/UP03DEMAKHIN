namespace pr4_3
{
    class Pr
    {
        static void Main(string[] args)
        {
            Orc Громмаш = new Orc();
            Console.WriteLine(Orc.TotalGold);
            Orc Тралл = new Orc();
            Orc Дректар = new Orc();
            Console.WriteLine(Orc.TotalGold);
            Orc Нарзул = new Orc();
            Orc Гаррош = new Orc();
            Orc Ленивый_батрак = new Orc();
            Console.WriteLine(Ленивый_батрак.StealGolD);
            Console.WriteLine("У него есть власть, которая и не снилась его отцу");
            Console.ReadKey(true);
        }
    }
    class Orc
    {
        private static int Count;
        public static int TotalGold { get; private set; }
        public int StealGolD { get; private set; }
        public Orc()
        {
            Count++;
            TotalGold += 2;
            if (Count > 5)
            {
                StealGolD += 2;
            }
        }
    }
}
