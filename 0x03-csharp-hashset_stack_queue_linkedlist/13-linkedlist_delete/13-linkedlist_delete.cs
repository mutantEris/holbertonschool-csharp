using System;
using System.Collections.Generic;

class LList
{
    public static void Delete(LinkedList<int> myLList, int index)
    {
        LinkedListNode<int> thing = myLList.First;
        for (int x = 0; x < myLList.Count; x++)
        {
            if (x == index)
            {
                myLList.Remove(thing.Value);
                return;
            }
            thing = thing.Next;
        }
    }
}