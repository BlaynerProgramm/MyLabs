using System;

namespace Task1
{
	internal class Program
	{
		private static void Main()
		{
			Console.WriteLine(DisintedNumber.DecomposeNumber(Convert.ToInt32(Console.ReadLine())));

			Console.WriteLine(new Square(Convert.ToInt32(Console.ReadLine())).DrowSquare());
		}
	}
}
