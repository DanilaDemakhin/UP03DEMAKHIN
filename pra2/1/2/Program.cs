namespace pr2_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CvUravnenie equation = new CvUravnenie(1, 3, -5);
            equation.GetRoots();
            Console.ReadKey(true);
        }
    }
    class CvUravnenie
    {
        private double A;
        private double B;
        private double C;
        private double D;
        private double X1;
        private double X2;
        private double CalDiscr()
        {
            D = Math.Pow(B, 2) - 4 * A * C;
            return D;
        }
        void CalculateRoots()
        {
            this.D = CalDiscr();
            if (D > 0)
            {
               X1 = (-B + Math.Sqrt(D)) / (2 * A);
               X2 = (-B - Math.Sqrt(D)) / (2 * A);
               Console.WriteLine($"x1 = {X1}");
               Console.WriteLine($"x2 = {X2}");
                Console.WriteLine("УРА");
            }
            else if (D == 0)
            {
               X1 = -B / (2 * A);
               Console.WriteLine($"X = {X1}");
            }
            else
            {
               Console.WriteLine("В уравнении нет корней! :(");
            }
        }
        public void GetRoots()
        {
           CalculateRoots();
        }
        public CvUravnenie(double A, double B, double C)
        {
           this.A = A;
           this.B = B;
           this.C = C;
        }
    }
}