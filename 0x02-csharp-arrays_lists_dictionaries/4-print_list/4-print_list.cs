using System;
using System.Collections.Generic;

class List
{
    public static List<int> CreatePrint(int size)
    {
        if (size < 0)
        {
        Console.WriteLine("Size cannot be negative");
        return null;
        }
    List<int> ints = new List<int>();
    for (int x = 0; x < size; x++)
    {
        ints.Add(x);
        Console.Write("{0:D}", x);
        if (x != size - 1)
            Console.Write(" ");
    }
    Console.WriteLine();
    return ints;
    }
}
