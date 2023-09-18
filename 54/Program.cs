using System;

public class Program
{
    public static void Main()
    {
        int[,] matrix = {
            {1, 4, 7, 2},
            {5, 9, 2, 3},
            {8, 4, 2, 4}
        };

        SortRowsDescending(matrix);

        PrintMatrix(matrix);
    }

    public static void SortRowsDescending(int[,] matrix)
    {
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);

        for (int i = 0; i < rows; i++)
        {
            int[] row = new int[cols];
            for (int j = 0; j < cols; j++)
            {
                row[j] = matrix[i, j];
            }

            Array.Sort(row, (a, b) => b.CompareTo(a));

            for (int j = 0; j < cols; j++)
            {
                matrix[i, j] = row[j];
            }
        }
    }

    public static void PrintMatrix(int[,] matrix)
    {
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write(matrix[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}
