using System;

public class Program
{
    public static void Main()
    {
        int[,,] array3D = Generate3DArray(2, 2, 2);
        Print3DArrayWithIndices(array3D);
    }

    public static int[,,] Generate3DArray(int xSize, int ySize, int zSize)
    {
        int[,,] array3D = new int[xSize, ySize, zSize];
        int currentNumber = 10;

        for (int x = 0; x < xSize; x++)
        {
            for (int y = 0; y < ySize; y++)
            {
                for (int z = 0; z < zSize; z++)
                {
                    array3D[x, y, z] = currentNumber;
                    currentNumber++;
                }
            }
        }

        return array3D;
    }

    public static void Print3DArrayWithIndices(int[,,] array3D)
    {
        int xSize = array3D.GetLength(0);
        int ySize = array3D.GetLength(1);
        int zSize = array3D.GetLength(2);

        for (int x = 0; x < xSize; x++)
        {
            for (int y = 0; y < ySize; y++)
            {
                for (int z = 0; z < zSize; z++)
                {
                    Console.Write($"{array3D[x, y, z]}({x},{y},{z}) ");
                }
                Console.WriteLine();
            }
        }
    }
}
