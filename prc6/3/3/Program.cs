namespace pr6_3
{
    class Chel
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public char Gender { get; set; }
        public Chel(string name, int age, char gender)
        {
            Name = name;
            Age = age;
            Gender = gender;
        }
    }
    class Rabotnik : Chel
    {
        public string Post { get; set; }
        public Rabotnik(string name, int age, char gender, string post)
            : base(name, age, gender)
        {
            Post = post;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Chel Nechaev = new Chel("Сергей Александрович Нечаев П-3", 35, 'M');
            Console.WriteLine(Nechaev.Name);
            Rabotnik Hraz =new Rabotnik("Харитонов Родион Захарыч", 127, 'М', "Полимер жидкий");
            Console.WriteLine(Hraz.Post);
            Chel Geralt = new Chel("Геральт из Ривии", 192, 'M');
            Console.WriteLine(Geralt.Name);
            Rabotnik Cirilla = new Rabotnik("Цирилла Де Тренсельвиль Четотам", 17, 'Ж', "Ведьмак");
            Console.WriteLine(Cirilla.Post);
            Chel VanDarkholme = new Chel("Ван Дархолм", 44, 'M');
            Console.WriteLine(VanDarkholme.Name);
            Rabotnik Billy = new Rabotnik("Билли Хэрингтон", 33, 'М', "F#cking slave");
            Console.WriteLine(Billy.Post);
            Console.ReadKey(true);
        }
    }
}