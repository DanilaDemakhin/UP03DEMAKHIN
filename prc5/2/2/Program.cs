namespace pr5_2
{
    internal class Pr
    {
        static void Main(string[] args)
        {
            List<IHello> hello = new List<IHello>();
            hello.Add(new Russian());
            hello.Add(new German());
            hello.Add(new Polish());
            hello.Add(new Czech());
            hello.Add(new Dutch());
            foreach (IHello hi in hello)
            {
                hi.SayHello();
            }
            Console.ReadKey(true);
        }
    }
    interface IHello
    {
        void SayHello();
    }
    class Russian : IHello
    {
        public void SayHello()
        {
            Console.WriteLine("Привет!");
        }
    }
    class German : IHello
    {
        public void SayHello()
        {
            Console.WriteLine("Guten Tag!");
        }
    }
    class Polish : IHello
    {
        public void SayHello()
        {
            Console.WriteLine("Cześć!");
        }
    }
    class Czech : IHello
    {
        public void SayHello()
        {
            Console.WriteLine("Ahoj!");
        }
    }
    class Dutch : IHello
    {
        public void SayHello()
        {
            Console.WriteLine("Hallo!");
        }
    }
}