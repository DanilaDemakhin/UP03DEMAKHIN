namespace pr3_6
{
    internal class Pr
    {
        static void Main(string[] args)
        {
            Randomchik num = new Randomchik();
            for (int i = 0; i < 10; i++)
            {
                num.AddNum();
            }
            Console.WriteLine(num.Otklonenie);
            Console.WriteLine(num.Difference);
            Console.WriteLine(num.Mediana);
            Console.ReadKey(true);
        }
        class Randomchik
        {
            private List<int> numList = new List<int>();
            Random rand = new Random();
            private int D
            {
                set
                {
                    SetLength(value);
                }
            }
            public double Srednee
            {
                get
                {
                    return CalcAverage();
                }
            }
            public double Difference
            {
                get
                {
                    return CalcDifference();
                }
            }
            public double Otklonenie
            {
                get
                {
                    return CalcStandardOtklonenie();
                }
            }
            public double Mediana
            {
                get
                {
                    return CalcMediana();
                }
            }
            private void SetLength(int S)
            {
                S = numList.Count;
            }
            public void AddNum()
            {
                numList.Add(rand.Next(101));
            }
            public void RemoveNum(int num)
            {
                numList.Remove(num);
            }
            private double CalcAverage()
            {
                int sum = 0;
                foreach (int num in numList)
                {
                    sum += num;
                }
                return sum / numList.Count;
            }
            private double CalcDifference()
            {
                double sum = 0;
                foreach (int num in numList)
                {
                    sum += Math.Pow((num - Srednee), 2);
                }
                return Math.Round(sum / numList.Count, 2);
            }
            private double CalcStandardOtklonenie()
            {
                CalcDifference();
                return Math.Round(Math.Sqrt(Difference), 2);
            }
            private double CalcMediana()
            {
                numList.Sort();
                if (numList.Count % 2 == 0)
                {
                    return (numList[numList.Count / 2] + numList[numList.Count / 2 - 1]) / 2;
                }
                else
                {
                    double middle = numList.Count / 2;
                    middle = Math.Ceiling(middle);
                    return numList[Convert.ToInt32(middle)];
                }
            }
        }
    }
}