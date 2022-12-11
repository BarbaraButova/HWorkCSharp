using static System.Console;
/// <summary>
/// Библиотека для решения задач
/// <para>Метод создания массива - CreateArray </para>
/// <para>Метод заполнения массива - FillArray </para>
/// <para> Метод вывода массива - PrintArray </para>
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
/// Метод вывода массива
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



}
