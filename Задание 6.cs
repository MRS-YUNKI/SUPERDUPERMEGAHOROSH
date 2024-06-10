using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите коэффициент a: ");
        double a = Convert.ToDouble(Console.ReadLine());

        Console.Write("Введите коэффициент b: ");
        double b = Convert.ToDouble(Console.ReadLine());

        Console.Write("Введите коэффициент c: ");
        double c = Convert.ToDouble(Console.ReadLine());

        Console.Write("Введите коэффициент d: ");
        double d = Convert.ToDouble(Console.ReadLine());

        Console.Write("Введите начальное значение диапазона: ");
        double start = Convert.ToDouble(Console.ReadLine());

        Console.Write("Введите конечное значение диапазона: ");
        double end = Convert.ToDouble(Console.ReadLine());

        Console.Write("Введите шаг: ");
        double step = Convert.ToDouble(Console.ReadLine());

        for (double x = start; x <= end; x += step)
        {
            double linear = a * x + b;
            double quadratic = a * x * x + b * x + c;
            double cubic = a * x * x * x + b * x * x + c * x + d;

            Console.WriteLine($"Для x = {x:F2}: линейное = {linear:F2}, квадратное = {quadratic:F2}, кубическое = {cubic:F2}");
        }
    }
}
