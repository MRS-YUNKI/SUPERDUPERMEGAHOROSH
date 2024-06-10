
using System;

namespace TypeConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Конвертация из аргументов командной строки:");
            ConvertFromArgs(args);
            
            Console.WriteLine("\nКонвертация из ввода с консоли:");
            ConvertFromConsole();
        }

        static void ConvertFromArgs(string[] args)
        {
            if (args.Length != 3)
            {
                Console.WriteLine("Необходимо ввести 3 аргумента командной строки.");
                return;
            }

            // double
            Console.WriteLine("Double:");
            Console.WriteLine($"Convert.ToDouble: {Convert.ToDouble(args[0])}");
            Console.WriteLine($"double.Parse: {double.Parse(args[0])}");
            if (double.TryParse(args[0], out double parsedDouble))
            {
                Console.WriteLine($"double.TryParse: {parsedDouble}");
            }
            else
            {
                Console.WriteLine($"double.TryParse: Преобразование не удалось.");
            }

            // bool
            Console.WriteLine("\nBool:");
            Console.WriteLine($"Convert.ToBoolean: {Convert.ToBoolean(args[1])}");
            Console.WriteLine($"bool.Parse: {bool.Parse(args[1])}");
            if (bool.TryParse(args[1], out bool parsedBool))
            {
                Console.WriteLine($"bool.TryParse: {parsedBool}");
            }
            else
            {
                Console.WriteLine($"bool.TryParse: Преобразование не удалось.");
            }

            // uint
            Console.WriteLine("\nUInt:");
            Console.WriteLine($"Convert.ToUInt32: {Convert.ToUInt32(args[2])}");
            Console.WriteLine($"uint.Parse: {uint.Parse(args[2])}");
            if (uint.TryParse(args[2], out uint parsedUInt))
            {
                Console.WriteLine($"uint.TryParse: {parsedUInt}");
            }
            else
            {
                Console.WriteLine($"uint.TryParse: Преобразование не удалось.");
            }
        }

        static void ConvertFromConsole()
        {
            Console.WriteLine("Введите три значения (double, bool, uint):");
            string inputDouble = Console.ReadLine();
            string inputBool = Console.ReadLine();
            string inputUInt = Console.ReadLine();

            // double
            Console.WriteLine("\nDouble:");
            Console.WriteLine($"Convert.ToDouble: {Convert.ToDouble(inputDouble)}");
            Console.WriteLine($"double.Parse: {double.Parse(inputDouble)}");
            if (double.TryParse(inputDouble, out double parsedDouble))
            {
                Console.WriteLine($"double.TryParse: {parsedDouble}");
            }
            else
            {
                Console.WriteLine($"double.TryParse: Преобразование не удалось.");
            }

            // bool
            Console.WriteLine("\nBool:");
            Console.WriteLine($"Convert.ToBoolean: {Convert.ToBoolean(inputBool)}");
            Console.WriteLine($"bool.Parse: {bool.Parse(inputBool)}");
            if (bool.TryParse(inputBool, out bool parsedBool))
            {
                Console.WriteLine($"bool.TryParse: {parsedBool}");
            }
            else
            {
                Console.WriteLine($"bool.TryParse: Преобразование не удалось.");
            }

            // uint
            Console.WriteLine("\nUInt:");
            Console.WriteLine($"Convert.ToUInt32: {Convert.ToUInt32(inputUInt)}");
            Console.WriteLine($"uint.Parse: {uint.Parse(inputUInt)}");
            if (uint.TryParse(inputUInt, out uint parsedUInt))
            {
                Console.WriteLine($"uint.TryParse: {parsedUInt}");
            }
            else
            {
                Console.WriteLine($"uint.TryParse: Преобразование не удалось.");
            }
        }
    }
}