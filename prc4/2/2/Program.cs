namespace pr4_2
{
    class Pr
    {
        static void Main(string[] args)
        {
            Поссылка package_1 = new Поссылка("Обычная посылка №1", 8);
            Поссылка package_2 = new Поссылка("Габаритная посылка №2", 10);
            Сервис_отправки sendingService = new Сервис_отправки();
            sendingService.SendPackage(package_1);
            sendingService.SendPackage(package_2);
            Console.ReadKey(true);
        }
    }
    class Поссылка
    {
        public string Описание
        {
            get;
            private set;
        }
        public int Вес
        {
            get;
            private set;
        }
        public Поссылка(string description, int weight)
        {
            Описание = description;
            Вес = weight;
        }
    }
    class Сервис_отправки
    {
        private static int LimWeight;
        private const int Lim = 15;
        public void SendPackage(Поссылка package)
        {
            LimWeight += package.Вес;
            if (LimWeight >= Lim)
            {
                Console.WriteLine("Попадос. Вес посылок превышает лимит, отправка прервана.");
            }
            else
            {
                Console.WriteLine("{0} весом {1} кг успешно отправлена.", package.Описание, package.Вес);
            }
        }
    }
}