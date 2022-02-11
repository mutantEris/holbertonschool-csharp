using System;
using System.Collections.Generic;

class LList
{
    public static int Length(LinkedList<int> myLList)
    {
        int x = 0;
        foreach (int ite in myLList)
            x++;
        return x;
    }
}