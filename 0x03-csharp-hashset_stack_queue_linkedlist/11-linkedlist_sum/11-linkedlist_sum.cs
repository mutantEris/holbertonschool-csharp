using System;
using System.Collections.Generic;

class LList
{
	public static int Sum(LinkedList<int> myLList)
	{
		int x = 0;
		foreach (var value in myLList)
			x += value;
		return x;
	}
}