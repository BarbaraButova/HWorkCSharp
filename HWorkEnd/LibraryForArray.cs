
/// <summary>
/// Библиотека для работы с массивами
/// <para> Метод создания массива - CreateArray </para>
/// <para> Метод создания массива вещественных чисел - CreateArrayReal </para>
/// <para> Метод создания массива из строк - CreateArrayString </para>
/// <para> Метод заполнения массива случайными числами от min до max - FillArray </para>
/// <para> Метод заполнения массива случайными вещественными числами - FillArrayReal </para>
/// <para> Метод пользовательского ввода элементов массива - EnterArrayElements <para>
/// <para> Метод заполнения массива случайными вещественными числами от min до max FillArrayReal <para>
/// <para> Метод вывода массива - PrintArray </para>
/// <para> Метод печати массива в виде числа в  15ричной СС - PrintArrayFift </para>
/// <para> Метод нахождения количества четных чисел в массиве - CountOfEven </para>
/// <para> Метод нахождения суммы элементов массива, стоящих на нечётных позициях - SumUnevenPos </para>
/// <para> Метод метод нахождения разницы между максимальным и минимальным элементами массива -  DifMaxMin </para>
/// <para> Метод нахождения количества положительных чисел массива - NumberOfPositive </para>
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
    /// Метод создания массива вещественных чисел
    /// </summary>
    /// <param name="count">Количество элементов нового массива</param>
    /// <returns>Созданный массив из count элементов</returns>
    public static double[] CreateArrayReal(int count)
    {
        return new double[count];
    }
    /// <summary>
    /// Метод создания массива строк
    /// </summary>
    /// <param name="count"></param>
    /// <returns></returns>
    public static string[] CreateArrayString(int count)
    {
        return new string[count];
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
            array[i] = Random.Shared.Next(min, max);
        }

    }
    /// <summary>
    /// Метод создания массива из строк
    /// </summary>
    /// <param name="count"></param>
    /// <returns></returns>

    /// <summary>
    /// // Метод заполнения массива случайными вещественными числами
    /// </summary>
    /// <param name="array"> пустой массив </param>
    /// <param name="min">минимальное значение элемента массива</param>
    /// <param name="max">максимальное значение элемента массива</param>
    public static void FillArrayReal(double[] array, int min, int max)
    {
        int size = array.Length;
        for (int i = 0; i < size; i++)
        {
            Random number = new Random();
            array[i] = (max + 1 - min) * number.NextDouble() + min;
        }

    }
    /// <summary>
    /// Метод пользовательского ввода элементов массива
    /// </summary>
    /// <param name="array"></param>
    public static void EnterArrayElements(int[] array)
    {
        int size = array.Length;
        for (int i = 0; i < size; i++)
        {
            Console.WriteLine($"введите {i+1}-е число");
            array[i] = Convert.ToInt32(Console.ReadLine());
        }
    }

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

    /// Метод печати массива
    /// </summary>
    /// <param name="array">имя массива</param>
    /// <returns></returns>
    public static string PrintArrayReal(double[] array)
    {
        string output = String.Empty;
        int size = array.Length;
        for (int i = 0; i < size; i++)
        {
            output += $" {array[i]:f3} ";
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
                if (array[i] % 2 == 0)
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
    public static double DifMaxMin(double[] array)
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
        /// <summary>
        /// Метод нахождения количества положительных чисел массива
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
    public static int NumberOfPositive(int[] array)
    {
        int count = 0;
        for (int i = 0, size = array.Length; i < size; i++)
        {
            if (array[i] > 0)
            count++;
        }
        return count;
    }

    public static int CountCharforArray (string array)
    {
        int count = 0;
        int countChar = 3;
        int size = array.Length;
        for (int i = 0; i < size; i++)
        {
            if (array[i].Length <= countChar)
            {
                count++;
            }
        }
        return count;
    }

}
