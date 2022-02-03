using System;

class Program
{
    static void Main(string[] args)
    {
        for(int x = 0; x < 9; x++)
        {
            for(int g = x + 1; g < 10; g++)
            {
                if (x < 8)
                    Console.Write("{0}{1}, ", x, g);
                else
                    Console.Write("{0}{1}\n", x, g);
            }
        }
    }
}