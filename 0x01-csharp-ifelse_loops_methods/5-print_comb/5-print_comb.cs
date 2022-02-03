using System;

class Program
{
    static void Main(string[] args)
    {
        int x;
        for (x = 0; x <= 98; x++)
            Console.Write("{0:D2}, ", x);
        Console.Write("{0:D2}\n", x);
    }
}