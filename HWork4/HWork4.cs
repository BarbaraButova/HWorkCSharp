using static System.Console;
using static LibraryForArray;
/// <summary>
/// домашняя работа к семинару 4
/// </summary>
public static class HWork4
{
    /// <summary>
    /// Задача №25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B. НЕЛЬЗЯ ИСПОЛЬЗОВАТЬ Math.Pow
    /// </summary>
    public static void Task25()
    {
        Console.WriteLine("Введите первое число");
        int numberA = Convert.ToInt32(ReadLine());
        Console.WriteLine("Введите второе число");
        int numberB = Convert.ToInt32(ReadLine());
        Console.WriteLine($"{numberA} в степени {numberB} = {LibraryTasks.Pow(numberA, numberB)}");
    }
    /// <summary>
    ///  Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе. Строки использовать нельзя.
    /// </summary>
    public static void Task27()
    {
        WriteLine("Введите число");
        int number = Math.Abs(Convert.ToInt32(ReadLine()));
          
        int numberOfDigits = Convert.ToInt32(Math.Log10(number) - (Math.Log10(number) % 1));
        int firstDigit = Math.DivRem(number, Convert.ToInt32(Math.Pow(10, numberOfDigits)), out int remainder);
        int sum = firstDigit;
        while (numberOfDigits >= 1)
            {
                int power10 = Convert.ToInt32(Math.Pow(10, numberOfDigits));
                int digit = Math.DivRem(remainder, power10, out remainder);
                sum += digit;
                numberOfDigits--;
            }
        sum = sum + remainder;
        WriteLine($"Сумма цифр числа {number} = {sum}");

    }
    /// <summary>
    /// Задача 29: Напишите программу, которая задаёт массив из N элементов (из диапазона [0-14] ) и выводит на экран десятичное представление числа, записанного в СС по основанию 15
    /// </summary>
    public static void Task29()
    {
        WriteLine("Введите число элементов массива");
        int N = Convert.ToInt32(ReadLine());
        int[] array = CreateArray(N);
        FillArray(array, 0, 15);
        WriteLine(PrintArray(array));
    }
}

