using System;

namespace MyMath
{
    public class Matrix
    {
        public static int[,] Divide(int[,] matrix, int num)
        {
            if (num == 0) 
            {
                Console.WriteLine("Num cannot be 0");
                return null;
            }
            if (matrix == null)
                return null;
            int[,] g = new int[matrix.GetLength(0),  matrix.GetLength(1)];
            for (int x = 0; x < matrix.GetLength(0); x++)
            {
                for (int y = 0; y < matrix.GetLength(0); y++)
                {
                    g[x, y] = matrix[x, y] / num;
                }
            }
            return g;
        }
    }
}