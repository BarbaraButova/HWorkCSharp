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
                for (int power = 1; power <= numberB; power++)
                {
                AToThePowerB *= numberA;
                }
            }
        WriteLine($"{numberA} в степени {numberB} = {AToThePowerB}");
    }
    /// <summary>
    ///  Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе. Строки использовать нельзя.
    /// </summary>
    public static void Task27()
    {
        WriteLine("Введите число");
        int number = Math.Abs(Convert.ToInt32(ReadLine()));
          
        int numberOfDigits = Convert.ToInt32(Math.Log10(number) - (Math.Log10(number) % 1) + 1);
        int count = numberOfDigits - 1;
        int firstDigit = Math.DivRem(number, Convert.ToInt32(Math.Pow(10, count)), out int remainder);
        int sum = firstDigit;
        while (count >= 1)
            {
                int power10 = Convert.ToInt32(Math.Pow(10, count));
                int digit = Math.DivRem(remainder, power10, out remainder);
                sum += digit;
                count--;
            }
        sum = sum + remainder;
        WriteLine($"Сумма цифр числа {number} = {sum}");

    }
    /// <summary>
    /// Задача 29: Напишите программу, которая задаёт массив из N элементов (из диапазона [0-14] ) и выводит на экран десятичное представление числа, записанного в СС по основанию 15
    /// </summary>
    public static void Task29()
    {
        
    }
}

