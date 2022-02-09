using System;
using System.Collections.Generic;

class List
{
	public static int SafePrint(List<int> myList, int n)
    {
		int x = 0;
		try
		{
			for (; x < n; x++)
				Console.WriteLine(myList[x]);
			return x;
		}
		catch (System.Exception)
		{
			return x;
		}
	}
}