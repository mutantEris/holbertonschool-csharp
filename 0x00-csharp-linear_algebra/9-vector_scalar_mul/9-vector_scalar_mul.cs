using System;
using System.Collections.Generic;

class VectorMath
{
    public static double[] Multiply(double[] vector, double scalar)
    {
        if (vector.Length < 2 || vector.Length > 3)
            return new double[] {-1};
        var x = new List<double>();
        foreach (double g in vector)
            x.Add(g*scalar);
        return x.ToArray();
    }
}