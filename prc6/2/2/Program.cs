namespace pr6_2
{
    class Transport
    {
        public string name { get; set; }
        public int max_speed { get; set; }
        public Transport(string name, int speed)
        {
            max_speed = speed;
            this.name = name;
        }
    }
    class Brigada : Transport
    {
        public void Betono_meshalka()
        {
            Console.WriteLine("Мешаем бетон (бригада строитилей жрёт самогон)");
        }
        public Brigada(string name, int speed) : base(name, speed) { }
    }
    class Политех_машина : Transport
    {
        public void MuzloVkl()
        {
            Console.WriteLine("Громко включаем плохую музыку (k-pop)");
        }
        public Политех_машина(string name, int speed) : base(name, speed) { }
    }
    class Samolet : Transport
    {
        public void Opilyaem()
        {
            Console.WriteLine("Опыляем поле (удобрениями)");
        }
        public Samolet(string name, int speed) : base(name, speed) { }
    }
    internal class pr
    {
        static void Main(string[] args)
        {
            Политех_машина Polytech = new Политех_машина("Политех-машина", 100);
            Polytech.MuzloVkl();
            Samolet Istrebitel = new Samolet("МиГ-29", 2400);
            Istrebitel.Opilyaem();
            Brigada beton = new Brigada("Бетоносмеситель Helmut BM63", 10);
            beton.Betono_meshalka();
            Console.ReadKey(true);
        }
    }
}
