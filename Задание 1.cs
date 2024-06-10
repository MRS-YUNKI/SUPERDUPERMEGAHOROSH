using System;

class Program
{
    static void Main()
    {
        PrintDataTypeInfo("int", int.MinValue, int.MaxValue, sizeof(int), "Используется для хранения целых чисел.");
        PrintDataTypeInfo("long", long.MinValue, long.MaxValue, sizeof(long), "Используется для хранения больших целых чисел.");
        PrintDataTypeInfo("uint", uint.MinValue, uint.MaxValue, sizeof(uint), "Используется для хранения неотрицательных целых чисел.");
        PrintDataTypeInfo("double", double.MinValue, double.MaxValue, sizeof(double), "Используется для хранения чисел с плавающей точкой двойной точности.");
        PrintDataTypeInfo("float", float.MinValue, float.MaxValue, sizeof(float), "Используется для хранения чисел с плавающей точкой одинарной точности.");
        PrintDataTypeInfo("decimal", decimal.MinValue, decimal.MaxValue, sizeof(decimal), "Используется для хранения десятичных чисел с высокой точностью.");
        PrintDataTypeInfo("char", char.MinValue, char.MaxValue, sizeof(char), "Используется для хранения одного символа Unicode.");
        PrintDataTypeInfo("boolean", bool.FalseString, bool.TrueString, sizeof(bool), "Используется для хранения логических значений, то есть истина или ложь.");
    }

    static void PrintDataTypeInfo(string typeName, object minValue, object maxValue, int size, string description)
    {
        Console.WriteLine($"Тип данных: {typeName}");
        Console.WriteLine($"Минимальное значение: {minValue}");
        Console.WriteLine($"Максимальное значение: {maxValue}");
        Console.WriteLine($"Занимаемая память: {size} байт");
        Console.WriteLine($"Описание: {description}");
        Console.WriteLine();
    }
}
