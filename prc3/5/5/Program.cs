namespace pr3_5
{
    internal class Pr
    {
        static void Main(string[] args)
        {
            SmsMessage sms = new SmsMessage(" Огого! На ваш счёт зачислено постулпение 15000 рублей! Скорее успейте перевести деньги на свой киви кошелёк", 100, 2, 0.9);
            sms.SendSmS();
            Console.ReadKey(true);
        }
        class SmsMessage
        {
            private string Message_text;
            private int Max_length;
            private double Price_initial;
            private double Price_simvol;
            public string MessageText
            {
                get
                {
                    return Message_text;
                }
                private set
                {
                    Message_text = NormMessageText(value, Max_length);
                }
            }
            public int MaxLength
            {
                get
                {
                    return Max_length;
                }
                private set
                {
                    Max_length = value;
                }
            }
            public double InitialPrice
            {
                get
                {
                    return Price_initial;
                }
                private set
                {
                    Price_initial = value;
                }
            }
            public double SimvoolPrice
            {
                get
                {
                    return Price_simvol;
                }
                private set
                {
                    Price_simvol = value;
                }
            }
            private double Price
            {
                get
                {
                    return CalculatePrice(Price_initial, Price_simvol);
                }
            }
            public SmsMessage(string text, int length, double initialprice, double symbolprice)
            {
                MessageText = text;
                MaxLength = length;
                InitialPrice = initialprice;
                SimvoolPrice = symbolprice;
            }
            public void SendSmS()
            {

                Console.WriteLine($"Вам пришло сообщение: '{Message_text}'  с длиной в {Message_text.Length} символов и стоимостью в {Price} рублей");
            }
            private string NormMessageText(string text, int length)
            {
                if (text.Length > length)
                {
                    return text.Substring(0, text.Length - length);
                }
                return text;
            }
            private double CalculatePrice(double initialprice, double symbolprice)
            {
                if (Message_text.Length < 100)
                {
                    return initialprice;
                }
                else
                {
                    int length = MessageText.Length - 100;
                    return initialprice + length * symbolprice;
                }
            }
        }
    }
}