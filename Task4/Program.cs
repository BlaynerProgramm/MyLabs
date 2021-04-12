using System;

namespace Task4
{
	internal class Program
	{
		private static void Main()
		{
			int[] a = new int[] { 1, 3, 5, 7, 3 };
			ArraySort.Sort(a, ArraySort.IntСompare);
			for (int i = 0; i < a.Length; i++)
			{
				Console.WriteLine(a[i]);
			}
		}
	}
}
