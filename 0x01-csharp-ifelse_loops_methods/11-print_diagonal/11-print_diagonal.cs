using System;

class Line
{
	public static void PrintDiagonal(int length)
	{
		for (int g = 0; g < length; g++)
		{
			for (int x = 0; x < g; x++)
			{
				Console.Write(' ');
			}
			Console.WriteLine("\\");
		}
		Console.WriteLine();
	}
}