namespace pr5_1
{
    internal class zoopark
    {
        static void PetAnimal(IAnimal animal)
        {
            Console.WriteLine("Мы гладим зверюшку, а она нам говорит:");
            animal.Voice();
        }
        static void Main(string[] args)
        {
            List<IAnimal> myAnimals = new List<IAnimal>();
            myAnimals.Add(new Dog());
            myAnimals.Add(new Cat());
            myAnimals.Add(new Owl());
            myAnimals.Add(new Plotva());
            myAnimals.Add(new Pena());
            foreach (IAnimal animal in myAnimals)
            {
                PetAnimal(animal);
            }
            Console.ReadKey(true);
        }
    }
    interface IAnimal
    {
        void Voice();
    }
    class Dog : IAnimal
    {
        public void Voice()
        {
            Console.WriteLine("Ав!");
        }
    }
    class Cat : IAnimal
    {
        public void Voice()
        {
            Console.WriteLine("Мав!");
        }
    }
    class Owl : IAnimal
    {
        private int GetCurrentTime()
        {
            return Convert.ToInt32(File.ReadAllText("current_time.txt"));
        }
        public void Voice()
        {
            int currentTime = GetCurrentTime();
            if ((currentTime >= 8) && (currentTime <= 21))
            {
                Console.WriteLine("Тисе, я спю!");
            }
            else
            {
                Console.WriteLine("Ух! Ух! Ух!");
            }
        }
    }
    class Plotva : IAnimal
    {
        public void Voice()
        {
            Console.WriteLine("Забери меня с собой, я приду сквозь злые ночи");
        }
    }
    class Pena : IAnimal
    {
        public void Voice()
        {
            bool animalIsFree = true;
            if (animalIsFree)
            {
                Console.WriteLine("Я пожилая кракозябра");
            }
            else
            {
                Console.WriteLine("Я хочу питсу");
            }
        }
    }
}