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
}