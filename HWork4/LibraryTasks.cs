/// <summary>
/// <para> Метод возведения числа A в степень B (для целых А и В) - Pow </para>
/// <para> Метод нахождения суммы цифр в целом числе - SumOfDigits </para>
/// <para> етод перевода числа, заданного массивом в 15ричную СС - ToFifteenNumeralSystem </para>
/// </summary>
public static class LibraryTasks
{
    // <summary>
    // возведение числа A в степень B, для целых чисел
    // </summary>
    /// <summary>
    /// Метод возведения числа A в степень B (для целых А и В)
    /// </summary>
    /// <param name="numberA"> число (целое) </param>
    /// <param name="numberB"> степень (целое число) </param>
    /// <returns></returns>
    public static double Pow(int numberA, int numberB)
    {
        int B = Math.Abs(numberB);
        double APowB = 1;
        for (int count = 1; count <= B; count++)
        {
            APowB *= numberA;
        }
        if (numberB < 0)
            APowB = 1 / APowB;
        return APowB;
    }

    /// <summary>
    /// Метод нахождения суммы цифр в целом числе
    /// </summary>
    /// <param name="number"> число (целое) </param>
    /// <returns></returns>
    public static int SumOfDigits(int number)
    {
        int sum = 0;
        while (number != 0)
        {
            sum += number % 10;
            number /= 10;
        }
        return sum;
    }

    /// <summary>
    /// Метод перевода числа, заданного массивом в 15ричную СС
    /// </summary>
    /// <param name="array"> массив </param>
    /// <returns></returns>
    public static double ToFifteenNumeralSystem(int[] array)
    {
        double result = 0;
        int count = array.Length;
        for (int i = 0; i < count; i++)
        {
            result += array[i] * Pow(15, count- 1- i);
        }
        return result;
    }
}