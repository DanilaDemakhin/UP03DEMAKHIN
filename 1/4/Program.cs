// See https://aka.ms/new-console-template for more information
Car jiga = new Car();
jiga.name = "Жигуль убитый";
jiga.speed = 49;
jiga.Print();

Car matiz = new Car();
matiz.name = "Матиз с ресничками";
matiz.speed = 52;
matiz.Print();

Car пятнарь = new Car();
пятнарь.name = "Пятняшка";
пятнарь.speed = 60;
пятнарь.Print();

Car Буханка = new Car();
Буханка.name = "Буханка";
Буханка.speed = 35;
Буханка.Print();

Console.WriteLine($"ГОНКИ");
if (пятнарь.speed>matiz.speed)
{
    Console.WriteLine($"Пятнарь пришёл первым");
}

if (matiz.speed>jiga.speed)
{
    Console.WriteLine($"Матиз пришёл вторым");
}

if (jiga.speed>Буханка.speed)
{
    Console.WriteLine($"Жигуль пришёл третьим, а буханка последней");
}

class Car
{
    public string name;
    public int speed;
    public void Print()
    {
        Console.WriteLine($"Название автомобиля: {name}");
        Console.WriteLine($"Максимальная скорость: {speed} км/ч");
    }
}

