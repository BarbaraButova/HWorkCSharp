using static System.Console;
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
        WriteLine("Введите первое число");
        double numberA = Convert.ToInt64(ReadLine());
        WriteLine("Введите второе число");
        double numberB = Convert.ToInt64(ReadLine());
        double AToThePowerB = 1;
            if (numberB < 0)
            {
                for (int power = -1; power >= numberB; power--)
                {
                    AToThePowerB *= 1/numberA;
                }
            }
            else
            {
                for (double power = 1; power <= numberB; power++)
                {
                AToThePowerB *= numberA;
                }
            }
        WriteLine($"{numberA} в степени {numberB} = {AToThePowerB}");
    }
}
