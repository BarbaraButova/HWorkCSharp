/// <summary>
/// Домашняя работа 6
/// <para> Задача 41 - Task41 </para>
/// </summary>
public static class HWork6
{
/// <summary>
/// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
/// </summary>
    public static void Task41()
    {
        Console.WriteLine("Введите количество чисел");
        int[] numbers = LibraryForArray.CreateArray(Convert.ToInt32(Console.ReadLine()));
        LibraryForArray.EnterArrayElements(numbers);
        Console.WriteLine($"Колличество положительных чисел = {LibraryForArray.NumberOfPositive(numbers)}");
    }
}
