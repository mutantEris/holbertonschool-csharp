using System;
using System.Collections.Generic;

class MatrixMath{
    public static double[,] Transpose(double[,] matrix)
    {
        if (matrix == null || matrix.Length == 0)
            return new double[,]{};
        double[,] bubble = new double[matrix.GetLength(1), matrix.GetLength(0)];
        for (int x = 0; x < bubble.GetLength(0); x++)
        {
            for (int y = 0; y < bubble.GetLength(1); y++)
                bubble[x, y] = matrix[y, x];
        }
        return bubble;
    }
} 