namespace pr3_4
{
    internal class Pr
    {
        static void Main(string[] args)
        {
            myIntlist num = new myIntlist();
            num.AddNum(4);
            num.AddNum(8);
            num.AddNum(15);
            num.AddNum(23);
            num.AddNum(42); //Это не числа из сериала Лост
            Console.WriteLine(num.Sum);
            Console.WriteLine(num.Average);
            Console.ReadKey(true);
        }
        class myIntlist
        {
            private List<int> numList = new List<int>();
            public int Sum
            {
                get
                {
                    return CalcSum();
                }
            }
            public double Average
            {
                get
                {
                    return CalcAverage();
                }
            }
            public void AddNum(int num)
            {
                numList.Add(num);
            }
            public void RemoveNum(int num)
            {
                numList.Remove(num);
            }
            private int CalcSum()
            {
                int sum = 0;
                foreach (int num in numList)
                {
                    sum += num;
                }
                return sum;
            }
            private double CalcAverage()
            {
                return Sum / (double)numList.Count;
            }
        }
    }
}