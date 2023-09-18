using System;

public class Program
{
    public static void Main()
    {
        int n = 4;
        int[,] spiralArray = GenerateSpiralArray(n);
        PrintArray(spiralArray, n);
    }

    public static int[,] GenerateSpiralArray(int n)
    {
        int[,] spiralArray = new int[n, n];
        int value = 1;
        int startRow = 0, endRow = n - 1, startCol = 0, endCol = n - 1;

        while (startRow <= endRow && startCol <= endCol)
        {
            for (int i = startCol; i <= endCol; i++)
            {
                spiralArray[startRow, i] = value++;
            }
            startRow++;

            for (int i = startRow; i <= endRow; i++)
            {
                spiralArray[i, endCol] = value++;
            }
            endCol--;

            for (int i = endCol; i >= startCol; i--)
            {
                spiralArray[endRow, i] = value++;
            }
            endRow--;

            for (int i = endRow; i >= startRow; i--)
            {
                spiralArray[i, startCol] = value++;
            }
            startCol++;
        }

        return spiralArray;
    }

    public static void PrintArray(int[,] array, int n)
    {
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write($"{array[i, j]:D2} ");
            }
            Console.WriteLine();
        }
    }
}
