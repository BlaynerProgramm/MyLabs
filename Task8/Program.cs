using System;

namespace Task8
{
	internal class Program
	{
		private static void Main()
		{
			DateTime dataNowUTC = DateTime.UtcNow;
			Console.WriteLine(dataNowUTC + " -  UTC");
			TimeZoneInfo zone = TimeZoneInfo.Local;
			Console.WriteLine($"{TimeZoneInfo.ConvertTimeFromUtc(dataNowUTC, zone)} - Местное");

			try
			{
				Console.WriteLine(Calculator.DivisionOfNumbers(1, 0));
			}
			catch (DivideByZeroException ex)
			{
				Console.WriteLine(ex.ToString());
			}
		}
	}
}
