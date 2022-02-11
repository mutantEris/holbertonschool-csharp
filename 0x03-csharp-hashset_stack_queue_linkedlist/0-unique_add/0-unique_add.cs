using System;
using System.Collections.Generic;

class List
{
	public static int Sum(List<int> myList)
	{
	int g = 0;
    HashSet<int> hash = new HashSet<int>(myList);
	foreach (int x in hash)
    {
		g += x;
    }
    return g;
	}
}