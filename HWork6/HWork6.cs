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

/// <summary>
/// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
/// </summary>
     public static void Task43()
    {
        Console.WriteLine("Введите переменную b1");
        double b1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите переменную b2");
        double b2 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите переменную k1");
        double k1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите переменную k2");
        double k2 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine($" Координаты точки пересечения прямых {LibraryTasks.IntersectionPoint(k1, b1, k2, b2)}");
    }
}
