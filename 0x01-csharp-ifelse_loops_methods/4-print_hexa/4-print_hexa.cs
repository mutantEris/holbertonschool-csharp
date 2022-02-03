using System;
    
class Program
{
    static void Main(string[] args)
    {
        for (int x = 0; x < 99; x++)
            Console.WriteLine("{0} = 0x{0:x}", x);
    }
}