using System;

public class Program
{
    public static void Main()
    {
        int[,] matrix = {
            {1, 4, 7, 2},
            {5, 9, 2, 3},
            {8, 4, 2, 4},
            {5, 2, 6, 7}
        };

        int minRow = FindRowWithMinSum(matrix);

        Console.WriteLine($"Строка с наименьшей суммой элементов: {minRow + 1} строка");
    }

    public static int FindRowWithMinSum(int[,] matrix)
    {
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);

        int minSum = int.MaxValue;
        int minRowIndex = -1;

        for (int i = 0; i < rows; i++)
        {
            int rowSum = 0;
            for (int j = 0; j < cols; j++)
            {
                rowSum += matrix[i, j];
            }

            if (rowSum < minSum)
            {
                minSum = rowSum;
                minRowIndex = i;
            }
        }

        return minRowIndex;
    }
}
