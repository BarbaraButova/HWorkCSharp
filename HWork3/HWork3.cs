using static System.Console;
/// <summary>
/// Домашняя работа к семинару 3
/// </summary>
public static class HWork3
{
/// <summary>
/// Задача №19: Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
/// </summary>
/// <param name="number">заданное пятизначное число</param>
public static void Task19 (int number)
{
        int n = number;
        if (n < 0)
        {
         n = n * -1;   
        
            if (n > 9999 && n <= 99999)
            {   //n=12345
                int div = Math.DivRem (n, 10, out int digitRight); // div = 1234 dR = 5
                int digitLeft = Math.DivRem(div, 1000, out int remainder); // dL = 1 rem = 234
                if (digitRight == digitLeft)
                {
                    div = Math.DivRem(remainder, 10, out digitLeft); // div = 23 dL = 4
                    digitRight = Math.DivRem(div, 10, out remainder); // dR = 2 rem = 3
                    if (digitRight == digitLeft)
                    { WriteLine($"Число {n} является палиндромом"); }
                    else { WriteLine("Число не является палиндромом"); }
                }
                else { WriteLine("Число не является палиндромом"); }
            }
            else { WriteLine("Число не пятизначное"); }
        }
    } 
}