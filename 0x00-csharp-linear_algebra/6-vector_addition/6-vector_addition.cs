using System;
using System.Collections.Generic;

class VectorMath{
    public static double[] Add(double[] vector1, double[] vector2)
    {
        int x = vector1.Length;
        int y = vector2.Length;
        if (x != y || x < 2 || x > 3)
            return new double[] {-1};
        var ls = new List<double>();
        for (int g = 0; g < x; g++)
            ls.Add(vector1[g] + vector2[g]);
        return ls.ToArray();
    }
}