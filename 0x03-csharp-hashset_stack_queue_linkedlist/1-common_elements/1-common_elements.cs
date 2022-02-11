using System;
using System.Collections.Generic;

class List
{
	public static List<int> CommonElements(List<int> list1, List<int> list2)
	{
		List<int> list = new List<int>();
		foreach (int g in list1)
		{
			if (!list.Contains(g) && list2.Contains(g))
				list.Add(g);
		}
		list.Sort();
		return list;
	}
}