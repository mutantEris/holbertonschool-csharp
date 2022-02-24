using System;
using System.Collections.Generic;

class VectorMath
{
    public static double[] Multiply(double[] vector, double scalar)
    {
        if (vector.Length < 2 || vector.Length > 3)
            return new double[] {-1};
        var x = new List<double>();
        foreach (double bubble in vector)
            x.Add(bubble*scalar);
        return x.ToArray();
    }
}