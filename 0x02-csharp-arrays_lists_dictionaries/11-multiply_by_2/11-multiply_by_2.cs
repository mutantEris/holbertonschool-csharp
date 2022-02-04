using System;
using System.Collections.Generic;

class Dictionary
{
    public static Dictionary<string, int> MultiplyBy2(Dictionary<string, int> myDict)
    {
        Dictionary<string, int> x2combo = new Dictionary<string, int>();
        foreach (var x in myDict)
            x2combo.Add(x.Key, x.Value * 2);
        return x2combo;
    }
}