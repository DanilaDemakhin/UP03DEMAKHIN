using pr5_5.pr4_1;
namespace pr5_5
{
    class Pr
    {
        static void Main(string[] args)
        {
            Znak Igni = new Znak("Знак игни", 120, "Кабина Эредина улетает.");
            Znak Aard = new Znak("Знак аард", 130, "Гюнтер О'Дим повержен");
            Koldun Geralt = new Koldun("Геральт из Ривии", 250);
            Geralt.CastSpell(Igni);
            Geralt.CastSpell(Aard);
            Console.ReadKey();
        }
    }
    interface IZnak
    {
        string Name
        {
            get;
            set;
        }
        int Mana
        {
            get;
            set;
        }
        void WriteInfo();
    }
    namespace pr4_1
    {
        class Znak
        {
            public string Name { get; private set; }
            public int Mana { get; private set; }
            private string Effect { get; set; }
            public Znak(string name, int mana, string effect)
            {
                Name = name;
                Mana = mana;
                Effect = effect;
            }
            public void Use()
            {
                Console.WriteLine(Effect);
            }
        }
        class Koldun
        {
            public string Name { get; private set; }
            public int Mana { get; private set; }
            public Koldun(string name, int mana)
            {
                Name = name;
                Mana = mana;
            }
            public void CastSpell(Znak znak)
            {
                if (Mana >= znak.Mana)
                {
                    Mana -= znak.Mana;
                    Console.WriteLine("{0} колдует!", Name);
                    znak.Use();
                }
                else
                {
                    int mana = znak.Mana - Mana;
                    Console.WriteLine(
                        "Для использования {0} не хватает {1} единиц маны. Хлебните эликсир Гром!",
                        znak.Name, mana);
                }
            }
        }
    }
}