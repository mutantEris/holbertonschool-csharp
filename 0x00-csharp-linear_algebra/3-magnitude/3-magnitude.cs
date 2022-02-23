using System;

class VectorMath
{
    /// <summary> finds longth </summary>
    public static double Magnitude(double[] vector)
    {
        if (vector == null || vector.Length < 2 || vector.Length > 3)
            return -1;
        double sum = 0;
        foreach(double n in vector)
        {
            sum += n * n;
        }
        return Math.Round(Math.Sqrt(sum), 2);
    }
}