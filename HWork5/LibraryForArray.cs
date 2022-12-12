using static System.Console;
/// <summary>
/// Библиотека для работы с массивами
/// <para> Метод создания массива - CreateArray </para>
/// <para> Метод заполнения массива случайными числами от min до max - FillArray </para>
/// <para> Метод заполнения массива случайными вещественными числами от min до max FillArrayReal <para>
/// <para> Метод вывода массива - PrintArray </para>
/// <para> Метод печати массива в виде числа в  15ричной СС - PrintArrayFift </para>
/// <para> Метод нахождения количества четных чисел в массиве - CountOfEven </para>
/// <para> Метод нахождения суммы элементов массива, стоящих на нечётных позициях - SumUnevenPos </para>
/// <para> Метод метод нахождения разницы между максимальным и минимальным элементами массива -  DifMaxMin </para>
/// </summary>
public static class LibraryForArray
{
/// <summary>
/// Метод создания массива
/// </summary>
/// <param name="count">Количество элементов нового массива</param>
/// <returns>Созданный массив из count элементов</returns>
    public static int[] CreateArray(int count)
    
    {
        return new int[count];
    }
/// <summary>
/// Метод заполнения массива случайными целыми числами от min до max
/// </summary>
/// <param name="array"> пустой массив </param>
/// <param name="min">минимальное значение элемента массива</param>
/// <param name="max">максимальное значение элемента массива</param>
    public static void FillArray(int[] array, int min, int max)
    {
        int size = array.Length;
        for (int i = 0; i < size; i++)
        {
            array[i] = Random.Shared.Next(min,max);
        }

    }


// Метод заполнения массива случайными вещественными числами 







/// Метод печати массива
/// </summary>
/// <param name="array">имя массива</param>
/// <returns></returns>
public static string PrintArray(int[] array)
    {
        string output = String.Empty;
        int size = array.Length;
        for (int i = 0; i < size; i++)
        {
            output += $" {array[i],3} ";
        }
        return output;
    }

/// <summary>
/// Метод печати массива в виде числа в  15ричной СС
/// </summary>
/// <param name="array"></param>
/// <returns></returns>
public static string PrintArrayFift(int[] array)
    {
        string output = String.Empty;
        int size = array.Length;
        for (int i = 0; i < size; i++)
        {
            if (array[i] == 10)
                output += $"A";
            else if (array[i] == 11)
                output += $"B";
            else if (array[i] == 12)
                output += $"C";
            else if (array[i] == 13)
                output += $"D";
            else if (array[i] == 14)
                output += $"E";
            else
                output += $"{array[i]}";
        }
        return output;
    }

    /// <summary>
    /// Метод нахождения количества четных чисел в массиве
    /// </summary>
    /// <param name="array"> массив </param>
    /// <returns></returns>
    public static int CountOfEven(int[] array)
    {
        int sizeArray = array.Length;
        int count = 0;
        for (int i = 0; i < sizeArray; i++)
        {   
            if (array[i]%2 == 0)
            {
                count++;
            }
        }
        return count;    
    }

    /// <summary>
    /// Метод нахождения суммы элементов массива, стоящих на нечётных позициях.
    /// </summary>
    /// <returns></returns>
    public static int SumUnevenPos(int[] array)
    {
        int sizeArray = array.Length;
        int sum = 0;
        int i = 1;
        while (i < sizeArray)
        {
            sum += array[i];
            i += 2;
        }
        return sum;
    }
    /// <summary>
    /// Метод метод нахождения разницы между максимальным и минимальным элементами массива.
    /// </summary>
    /// <returns></returns>
    public static double DifMaxMin(int[] array)
    {
        double max = array[0];
        double min = array[0];
        int sizeArray = array.Length;
        for (int i = 1; i < sizeArray; i++)
        {
            if (array[i] >= max)
            {
                max = array[i];
            }
            else if (array[i] <= min)
            {
                min = array[i];
            }
        }
        return max - min;

    }

}
