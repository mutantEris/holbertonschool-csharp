using System;
using System.Collections.Generic;

class VectorMath{
    public static double[] CrossProduct(double[] vector1, double[] vector2)
    {
        if(vector1.Length != 3 || vector2.Length != 3)
            return new double[] {-1};
        double x1 = vector1[0], y1 = vector1[1], z1 = vector1[2], x2 = vector2[0], y2 = vector2[1], z2 = vector2[2];
        double[] bubble = new double[3];
        bubble[0] = (y1 * z2) - (z1 * y2);
        bubble[1] = (z1 * x2) - (x1 * z2);
        bubble[2] = (x1 * y2) - (y1 * x2);
        return bubble;
    }
}