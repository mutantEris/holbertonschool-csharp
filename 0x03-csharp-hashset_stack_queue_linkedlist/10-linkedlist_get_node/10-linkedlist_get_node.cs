using System;
using System.Collections.Generic;

class LList
{
    public static int GetNode(LinkedList<int> myLList, int n)
    {
        int x = 0;
        foreach (int g in myLList)
        {
            if (x == n)
                return g;
            x++;
        }
    return 0;
    }
}