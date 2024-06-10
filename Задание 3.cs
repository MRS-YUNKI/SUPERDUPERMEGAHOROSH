using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите первый операнд:");
        double operand1;
        while (!double.TryParse(Console.ReadLine(), out operand1))
        {
            Console.WriteLine("Ошибка: Введите корректное число для первого операнда:");
        }

        Console.WriteLine("Введите операцию (+, -, *, /, %) для первой операции:");
        char operation1;
        while (!char.TryParse(Console.ReadLine(), out operation1) || !IsSupportedOperation(operation1))
        {
            Console.WriteLine("Ошибка: Введите корректную операцию (+, -, *, /, %):");
        }

        Console.WriteLine("Введите второй операнд:");
        double operand2;
        while (!double.TryParse(Console.ReadLine(), out operand2))
        {
            Console.WriteLine("Ошибка: Введите корректное число для второго операнда:");
        }

        Console.WriteLine("Введите операцию (+, -, *, /, %) для второй операции:");
        char operation2;
        while (!char.TryParse(Console.ReadLine(), out operation2) || !IsSupportedOperation(operation2))
        {
            Console.WriteLine("Ошибка: Введите корректную операцию (+, -, *, /, %):");
        }

        Console.WriteLine("Введите третий операнд:");
        double operand3;
        while (!double.TryParse(Console.ReadLine(), out operand3))
        {
            Console.WriteLine("Ошибка: Введите корректное число для третьего операнда:");
        }

        double result = 0;

        // Первая операция
        switch (operation1)
        {
            case '+':
                result = operand1 + operand2;
                break;
            case '-':
                result = operand1 - operand2;
                break;
            case '*':
                result = operand1 * operand2;
                break;
            case '/':
                if (operand2 != 0)
                {
                    result = operand1 / operand2;
                }
                else
                {
                    Console.WriteLine("Ошибка: Деление на ноль.");
                    return;
                }
                break;
            case '%':
                result = operand1 % operand2;
                break;
            default:
                Console.WriteLine("Ошибка: Неподдерживаемая операция для первых двух операндов.");
                return;
        }

        // Вторая операция
        switch (operation2)
        {
            case '+':
                result += operand3;
                break;
            case '-':
                result -= operand3;
                break;
            case '*':
                result *= operand3;
                break;
            case '/':
                if (operand3 != 0)
                {
                    result /= operand3;
                }
                else
                {
                    Console.WriteLine("Ошибка: Деление на ноль.");
                    return;
                }
                break;
            case '%':
                Console.WriteLine("Ошибка: Неподдерживаемая операция для третьего операнда.");
                return;
            default:
                Console.WriteLine("Ошибка: Неподдерживаемая операция.");
                return;
        }

        // Результат
        Console.WriteLine($"Результат: {result}");
    }

    static bool IsSupportedOperation(char operation)
    {
        return operation == '+' || operation == '-' || operation == '*' || operation == '/' || operation == '%';
    }
}
