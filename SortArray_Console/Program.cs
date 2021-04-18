using System;

namespace SortArray_Console
{
	internal class Program
	{
		private static void Main()
		{
			ArraySort sort = new(4, 8);
			Console.Write($"Массив:\n{sort}");
			Console.WriteLine($"Минимальный элемент массива  = {sort.GetMin()}");
			Console.WriteLine($"Сумма элементов = {sort.SumElements()}");
			sort.SortArray();
			Console.WriteLine($"Преобразование массива:\n{sort}");
		}
	}
}
