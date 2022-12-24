public static class LibraryFor2DimArray
{
/// <summary>
/// Метод создания двумерного массива
/// </summary>
/// <param name="rows"> количество строк </param>
/// <param name="columns"> количество столбцов </param>
/// <returns></returns>
    public static double[,] CreateArray(int rows, int columns)

    {
        return new double[rows, columns];
    }
/// <summary>
/// Метод заполнения двумерного массива
/// </summary>
/// <param name="array"></param>
/// <param name="min"></param>
/// <param name="max"></param>
/// <returns></returns>
    public static void FillArray(double[,] array, int min, int max)
    {   int rows = array.GetLength(0);
        int columns = array.GetLength(1);
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                Random number = new Random();
                array[i,j] = (max + 1 - min) * number.NextDouble() + min;                
            }
        }
    }
    /// <summary>
    /// Метод вывода массива
    /// </summary>
    /// <param name="array"></param>
    /// <returns></returns>
    public static string PrintArrayReal(double[,] array)
    {
        int rows = array.GetLength(0);
        int columns = array.GetLength(1);
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
                Console.Write($"{array[i, j]:f3} | ");
            Console.WriteLine();
        }
        return String.Empty;
    }
}