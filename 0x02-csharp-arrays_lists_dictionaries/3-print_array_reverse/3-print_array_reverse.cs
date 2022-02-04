using System;

class Array
{
	public static void Reverse(int[] array)
	{
		if (array == null || array.Length < 1)
			Console.WriteLine();
		else
		{
			for (int x = array.Length - 1; x > 0; x--)
			    Console.Write("{0} ", array[x]);
			Console.WriteLine(array[0]);
		}
	}
}