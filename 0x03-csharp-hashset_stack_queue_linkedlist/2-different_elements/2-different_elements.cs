using System;
using System.Collections.Generic;

class List
{
    public static List<int> DifferentElements(List<int> list1, List<int> list2)
    {
        HashSet<int> list = new HashSet<int>(list1);

        list.SymmetricExceptWith(list2);
        List<int> g = new List<int>(list);
        g.Sort();

        return g;
    }
}