/// <summary>
/// Домашняя работа к семинару 3
/// </summary>
public static class HWork3
{
    /// <summary>
    /// Задача №19: Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
    /// </summary>
    /// <param name="number">заданное пятизначное число</param>
    public static void Task19(int number)
    {
        int n = number;
        if (n < 0)
            n = n * -1;

        if ((n < 9999) && (n >= 99999))
            Console.WriteLine("Число не пятизначное");
        else
        {
            int div = Math.DivRem(n, 10, out int digitRight);
            int digitLeft = Math.DivRem(div, 1000, out int remainder);
            if (digitRight != digitLeft)
            {
                Console.WriteLine("Число не является палиндромом");
            }
            else
            {
                div = Math.DivRem(remainder, 10, out digitLeft);
                digitRight = Math.DivRem(div, 10, out remainder);

                if (digitRight != digitLeft)
                    Console.WriteLine("Число не является палиндромом");
                else Console.WriteLine("Число является палиндромом");
            }
        }
    }
}
