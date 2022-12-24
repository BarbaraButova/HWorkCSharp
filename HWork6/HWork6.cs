
public static class HWork6
{
/// <summary>
/// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
/// </summary>
    public static void Task34()
    {
        Console.WriteLine("Введите количество чисел");
        int[] numbers = LibraryForArray.CreateArray(Convert.ToInt32(Console.ReadLine()));
        LibraryForArray.EnterArrayElements(numbers);
        Console.WriteLine($"Колличество положительных чисел = {LibraryForArray.NumberOfPositive(numbers)}");
    }
}
