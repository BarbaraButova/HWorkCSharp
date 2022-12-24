public static class HWork7
{
    /// <summary>
    /// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
    /// </summary>
    public static void Task47()
    {
        double[,] arr = LibraryFor2DimArray.CreateArray(4, 4);
        LibraryFor2DimArray.FillArray(arr, 10, 20);
        LibraryFor2DimArray.PrintArrayReal(arr);
    }
}