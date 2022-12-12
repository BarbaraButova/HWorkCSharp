public static class LibraryTasks
{
    /// <summary>
    /// возведение числа A в степень B, для целых чисел
    /// </summary>
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
    /// Метод перевода в 15ричную СС
    /// </summary>
    //public static void ToFifteenNumeralSystem()
    // {

    //}
}