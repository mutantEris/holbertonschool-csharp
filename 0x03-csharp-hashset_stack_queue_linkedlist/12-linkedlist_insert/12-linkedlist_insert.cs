using System;
using System.Collections.Generic;

class LList
{
    public static LinkedListNode<int> Insert(LinkedList<int> myLList, int n)
    {
        foreach (int x in myLList)
        {
            if (n < x)
                return myLList.AddBefore(myLList.Find(x), n);
        }
        return myLList.AddLast(n);
    }
}