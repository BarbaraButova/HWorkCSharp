using static System.Console;
using static LibraryForArray;
using static LibraryTasks;
/// <summary>
/// домашняя работа к семинару 4
/// <para> Задача №25 - Task25</para>
/// <para> Задача №27 - Task27</para>
/// <para> Задача №29 - Task29</para>
/// </summary>
public static class HWork4
{
    /// <summary>
    /// Задача №25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B. НЕЛЬЗЯ ИСПОЛЬЗОВАТЬ Math.Pow
    /// </summary>
    public static void Task25()
    {
        WriteLine("Введите первое число");
        int numberA = Convert.ToInt32(ReadLine());
        WriteLine("Введите второе число");
        int numberB = Convert.ToInt32(ReadLine());
        WriteLine($"{numberA} в степени {numberB} = {LibraryTasks.Pow(numberA, numberB)}");
    }

    /// <summary>
    ///  Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе. Строки использовать нельзя.
    /// </summary>
    public static void Task27()
    {
        WriteLine("Введите число");
        int number = Math.Abs(Convert.ToInt32(ReadLine()));
        WriteLine($"Сумма цифр числа {number} = {SumOfDigits(number)}");
    }

    /// <summary>
    /// Задача 29: Напишите программу, которая задаёт массив из N элементов (из диапазона [0-14] ) и выводит на экран десятичное представление числа, записанного в СС по основанию 15
    /// </summary>
    public static void Task29()
    {
        WriteLine("Введите число элементов массива");
        int N = Convert.ToInt32(ReadLine());
        int[] array = CreateArray(N);
        FillArray(array, 0, 14);
        WriteLine($"{PrintArrayFift(array)} -> {ToFifteenNumeralSystem(array)}");
    }
}

