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
    public static void Task19()
    {
        WriteLine("Введите число");
        int number = Math.Abs(Convert.ToInt32(ReadLine()));
        if ((number > 9999) && (number <= 99999))
        {   int div = Math.DivRem(number, 10, out int digitRight);
            int digitLeft = Math.DivRem(div, 1000, out int remainder);
            if (digitRight == digitLeft)
            {
               div = Math.DivRem(remainder, 10, out digitLeft);
               digitRight = Math.DivRem(div, 10, out remainder);
               if (digitRight == digitLeft)
               WriteLine("Число является палиндромом");
               else 
               WriteLine("Число не является палиндромом");
            }
            else
            WriteLine("Число не является палиндромом");
        }     
        else
        WriteLine("Число не пятизначное");
            
    }
    /// <summary>
    /// Задача №23: Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.
    /// </summary> 
   public static void Task21()
   {
        WriteLine("Введите координаты первой точки через ';'");
        string pointA = ReadLine();
        string[] coordA = pointA.Split(new char[] { ';' });
        double Xa = Convert.ToDouble(coordA[0]);
        double Ya = Convert.ToDouble(coordA[1]);
        WriteLine("Введите координаты второй точки через ;");
        string pointB = ReadLine();
        string[] coordB = pointB.Split(new char[] { ';' });
        double Xb = Convert.ToDouble(coordB[0]);
        double Yb = Convert.ToDouble(coordB[1]);
        
        double distanceAB = Math.Sqrt(Math.Pow((Xb - Xa), 2) + Math.Pow((Yb - Ya), 2));
        Console.WriteLine($"Расстояние между точками = {distanceAB}");
    }
    /// <summary>
    /// Задача №29: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
    /// </summary>
    public static void Task29()
    {
        WriteLine("Введите число");
        int N = Math.Abs(Convert.ToInt32(ReadLine()));
        for (int num = 1; num <= N; num++)
        {
            WriteLine($"{num}^3 = {Math.Pow(num, 3)}");
        }
    }
}
    

