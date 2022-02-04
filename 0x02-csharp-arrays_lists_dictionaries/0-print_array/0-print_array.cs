using System;

class Array
{
    public static int[] CreatePrint(int size)
    {
        int[] wumbo;
        if (size < 0)
        {
            Console.WriteLine("Size cannot be negative");
            return null;
        }
        wumbo = new int[size];
        for (int x = 0; x < size; x++)
        {
            Console.Write("{0:D}", x);
            if (x != size - 1)
                Console.Write(" ");
            wumbo[x] = x;
        }
        Console.WriteLine();
        return wumbo;
    }
}