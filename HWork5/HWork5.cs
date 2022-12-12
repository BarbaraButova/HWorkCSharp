using static System.Console;
using static LibraryForArray;
using static LibraryTasks;
/// <summary>
/// <para> Задача 34 - Task34 </para>
/// </summary>
public static class HWork5
{
    /// <summary>
    /// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
    /// </summary>
    public static void Task34()
    {
        int[] array = CreateArray(15);
        FillArray(array, 100, 999);
        WriteLine($" Для массива:{PrintArray(array)} количество четных чисел = {CountOfEven(array)}");
    }

    /// <summary>
    /// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
    /// </summary>
    public static void Task36()
    {
        int[] array = CreateArray(14);
        FillArray(array, 0, 10);
        WriteLine($" Для массива [{PrintArray(array)}] cумма элементов, стоящих на нечётных позициях = {SumUnevenPos(array)}");
    }

    /// <summary>
    /// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
    /// </summary>
    public static void Task38()
    {
        int[] array = CreateArray(10);
        FillArray(array, -10, 10);
        WriteLine($" Для массива [{PrintArray(array)}] разница между максимальным и минимальным элементами массива = {DifMaxMin(array)}");

    }
}