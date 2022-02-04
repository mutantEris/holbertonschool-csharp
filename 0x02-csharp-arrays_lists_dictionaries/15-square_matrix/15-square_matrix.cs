using System;

    class Matrix
    {
        public static int[,] Square(int[,] myMatrix)
        {
            int x = myMatrix.GetLength(0);
            int y = myMatrix.GetLength(1);
            for (int z = 0; z < x; z++)
            {
                for (int g = 0; g < y; g++)
                    myMatrix[z,g] *= myMatrix[z,g];
            }
            return myMatrix;
        }
    }