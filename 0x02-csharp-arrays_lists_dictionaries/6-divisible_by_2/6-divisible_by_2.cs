using System;
using System.Collections.Generic;

class List
{
    public static List<bool> DivisibleBy2(List<int> myList)
    {
     List<bool> mults = new List<bool>();
        foreach (int x in myList)
            mults.Add(x % 2 == 0);
        return mults;
    }
}