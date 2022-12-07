/// <summary>
/// Домашняя работа к семинару 2
/// </summary>
public static class HWork2
{
    /// <summary>
    /// Задача №10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
    /// </summary>
    /// <param name="number">заданное число</param>
    public static void Task10(int number)
    {
        int n = number;
        if (n < 0)
        {
            n = n * -1;
        }
        if (n > 99 && n < 1000)
        {
            Console.WriteLine($"Вторая цифра числа = {(n / 10) % 10}");
        }
        else { Console.WriteLine("Число не трёхзначное"); }
    }

    /// <summary>
    /// Задача №13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
    /// </summary>
    /// <param name="number">заданное число</param>
    public static void Task13(int number)
    {
        int n = number;
        if (n < 0)
        {
            n = n * -1;
        }
        if (n > 99)
        {
            int a = Convert.ToInt32(Math.Pow(10, (Convert.ToInt32(Math.Log10(n)) - 2)));
            Console.WriteLine($"Третья цифра числа = {(n/a)%10}");
        }
        else 
        { Console.WriteLine("У заданного числа нет третьей цифры"); }
    }

    /// <summary>
    /// Задача №15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным
    /// </summary>
    /// <param name="dayNumber">номер дня недели</param>
    public static void Task15(int dayNumber)
    {
        int n = dayNumber;
        if (n > 0 && n < 8)
        {
            if (n<6)
            {
                Console.WriteLine("Это будний день:(");
            }
            else
            {
                Console.WriteLine("Ура, это выходной!");
            }
        }
        else { Console.WriteLine("На Земле нет такого дня недели"); }

    }
}


