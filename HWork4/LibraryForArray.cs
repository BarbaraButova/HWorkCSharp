using static System.Console;
/// <summary>
/// Библиотека для работы с массивами
/// <para> Метод создания массива - CreateArray </para>
/// <para> Метод заполнения массива - FillArray </para>
/// <para> Метод вывода массива - PrintArray </para>
/// <para> Метод печати массива в виде числа в  15ричной СС - PrintArrayFift </para>
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
/// Метод заполнения массива
/// </summary>
/// <param name="array">переменная для задания массива</param>
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
/// <summary>
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
            output += $"{array[i],3}";
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
}
