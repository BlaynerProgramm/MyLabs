using System;

namespace Task8
{
	internal class Calculator
	{
		public static int Sum(int a, int b) => a + b;
		public static int DifferenceNum(int a, int b) => a - b;
		public static int DivisionOfNumbers(int a, int b)
		{
			if (a == 0 || b == 0)
			{
				throw new DivideByZeroException("На ноль делить нельзя");
			}

			return a / b;
		}
	}
}