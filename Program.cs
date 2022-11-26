
void Zadacha19()
{
    Console.WriteLine("Введите пятизначное число");
    int number = Convert.ToInt32(Console.ReadLine());

    if (number / 10000 == number % 10 && number / 1000 % 10 == number % 100 / 10)
    {
        Console.WriteLine("Число является палиндромом");
    }
    else
    {
        Console.WriteLine("Число не является палиндромом");
    }

}
Zadacha19();




void Zadacha21()
{
    Random rand = new Random();
    double x = rand.Next(-5, 15);
    double y = rand.Next(-5, 15);
    double z = rand.Next(-5, 15);
    Console.WriteLine($"A({x}, {y}, {z})");

    double x1 = rand.Next(-10, 12);
    double y1 = rand.Next(-10, 12);
    double z1 = rand.Next(-10, 12);
    Console.WriteLine($"B({x1}, {y1}, {z1})");
    double result = Math.Sqrt(Math.Pow(x1 - x, 2) + Math.Pow(y1 - y, 2) + Math.Pow(z1 - z, 2));
    Console.WriteLine("Расстояние между точками A и B");

    Console.WriteLine(Math.Round(result, 2));
}

Zadacha21();



void Zaacha23()
{
    Console.WriteLine("Введите число");
    int number = Convert.ToInt32(Console.ReadLine());
    int count = 1;
    while (count <= number)
    {
        Console.WriteLine($"{count}*{count}*{count} = {Math.Pow(count, 3)}");
        count++;
    }
}