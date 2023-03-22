namespace pr6_4
{
    class Questions
    {
        public string vopros;
        public string otvet1; 
        public string otvet2; 
        public string otvet3; 
        public string otvet4; 
        public string result;     

        public string Res
        {
            get { return result; }
            set { result = value; }
        }

        public Questions(string question, string a, string b, string c, string d, string r)
        {
            this.vopros = question;
            this.otvet1 = a;
            this.otvet2 = b;
            this.otvet3 = c;
            this.otvet4 = d;
            this.result = r;
        }
        public void print() 
        {
            Console.WriteLine(this.vopros);
            Console.WriteLine(this.otvet1);
            Console.WriteLine(this.otvet2);
            Console.WriteLine(this.otvet3);
            Console.WriteLine(this.otvet4);
        }
    }
    class Pr
    {
        static void Main(string[] args)
        {
            int sum = 0;
            string res;
            Questions[] q = { 
                new Questions("Какая группа в ОПК самая лучшая", "a.ИСП-20-3", "b.ИСП-20-1", "c.ИСП-20-4", "d.ИСП-20-2", "b"),
                new Questions("Кто староста группы ИСП-20-1", "a.Демахин Данилочка", "b.Ван Даркхолм", "c.Человек-молекула", "d.Райан Гослинг", "a"),
                            };
            for (int i = 0; i < 2; i++) 
            {
                q[i].print();
                res = Console.ReadLine();
                if (res != null)
                {
                    if (res == q[i].Res)
                    {
                        sum++;
                    }
                }
                Console.WriteLine("Правильных ответов (по понятиям):{0}", sum);
                Console.ReadLine();
            }
        }
    }
}