using System;
using System.Collections.Generic;

class LList
{
    public static int FindNode(LinkedList<int> myLList, int value)
    {
        int x = 0;
        foreach (int g in myLList)
        {
            if (g == value)
                return x;
            x++;
        }
        return -1;
    }
}