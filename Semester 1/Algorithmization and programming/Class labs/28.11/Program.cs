using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("Введите n: ");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Введите t: ");
        int t = int.Parse(Console.ReadLine()), min = 0, sum_a = 0;
        for (int i = 1; i <= n; i++)
        {
            Console.WriteLine("Введите А и Б через Enter: ");
            int a = Convert.ToInt32(Console.ReadLine());
            sum_a += a;
            int b = Convert.ToInt32(Console.ReadLine());
            min = Math.Min(sum_a + t, min + b);
        }
        Console.WriteLine($"Mинимальная длина пути: {min}");
    }
}
