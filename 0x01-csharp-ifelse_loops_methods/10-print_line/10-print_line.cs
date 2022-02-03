using System;

class Line
{
    public static void PrintLine(int length)
    {
        for (int x = 0; x < length; x++)
            Console.Write('_');
        Console.WriteLine();
    }
}