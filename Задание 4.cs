using System;

class Program
{
    static void Main(string[] args)
    {
        // Ввод значения x
        Console.WriteLine("Введите значение x:");
        double x;
        while (!double.TryParse(Console.ReadLine(), out x))
        {
            Console.WriteLine("Ошибка: Введите корректное число для x:");
        }

        // Вычисление результатов выражений
        double result1 = 2 * Math.Pow(x, 2) - 7 * x + 4;
        double result2 = Math.Pow(x, 3) - 2 * Math.Pow(x, 2) + x - 2;
        double result3 = Math.Pow(Math.Sin(x), 2) + Math.Pow(Math.Cos(x), 2);

        // Результаты
        Console.WriteLine($"Результат выражения 2x^2 - 7x + 4 при x = {x}: {result1}");
        Console.WriteLine($"Результат выражения x^3 - 2x^2 + x - 2 при x = {x}: {result2}");
        Console.WriteLine($"Результат выражения sin^2(x) + cos^2(x) при x = {x}: {result3}");

        // Корни уравнения
        Console.WriteLine("Введите коэффициенты a, b и c для уравнения ax^2 + bx + c = 0:");

        double a;
        Console.Write("a: ");
        while (!double.TryParse(Console.ReadLine(), out a) || a == 0)
        {
            Console.WriteLine("Ошибка: Введите ненулевое корректное число для a:");
        }

        double b;
        Console.Write("b: ");
        while (!double.TryParse(Console.ReadLine(), out b))
        {
            Console.WriteLine("Ошибка: Введите корректное число для b:");
        }

        double c;
        Console.Write("c: ");
        while (!double.TryParse(Console.ReadLine(), out c))
        {
            Console.WriteLine("Ошибка: Введите корректное число для c:");
        }

        if (a != 0)
        {
            // Квадратное уравнение
            double discriminant = b * b - 4 * a * c;
            if (discriminant > 0)
            {
                double root1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
                double root2 = (-b - Math.Sqrt(discriminant)) / (2 * a);
                Console.WriteLine($"Корни квадратного уравнения: x1 = {root1}, x2 = {root2}");

                // Определение направления ветвей параболы
                if (a > 0)
                {
                    Console.WriteLine("Парабола направлена вверх.");
                }
                else
                {
                    Console.WriteLine("Парабола направлена вниз.");
                }

                // Нахождение вершины параболы
                double vertexX = -b / (2 * a);
                double vertexY = a * vertexX * vertexX + b * vertexX + c;
                Console.WriteLine($"Вершина параболы: ({vertexX}, {vertexY})");

                // Определение отрезков убывания и возрастания функции
                if (a > 0)
                {
                    Console.WriteLine("Функция убывает при x < вершины и возрастает при x > вершины.");
                }
                else
                {
                    Console.WriteLine("Функция возрастает при x < вершины и убывает при x > вершины.");
                }
            }
            else if (discriminant == 0)
            {
                double root = -b / (2 * a);
                Console.WriteLine($"Уравнение имеет один корень: x = {root}");
            }
            else
            {
                Console.WriteLine("Уравнение не имеет действительных корней.");
            }
        }
        else
        {
            // Линейное уравнение
            if (b != 0)
            {
                double root = -c / b;
                Console.WriteLine($"Корень линейного уравнения: x = {root}");
            }
            else if (c == 0)
            {
                Console.WriteLine("Уравнение имеет бесконечно много корней.");
            }
            else
            {
                Console.WriteLine("Уравнение не имеет корней.");
            }
        }
    }
}
