using System;

namespace Task2
{
	internal class Program
	{
		private static void Main()
		{
			#region BMI
			double height;
			int weight;
			Console.Write("Введите вес: ");
			if (int.TryParse(Console.ReadLine(), out int resultW))
			{
				weight = resultW;
			}
			else
			{
				throw new ArgumentException("Не верно введены данные");
			}

			Console.Write("Введите рост: ");
			if (double.TryParse(Console.ReadLine(), out double resultH))
			{
				height = resultH;
			}
			else
			{
				throw new ArgumentException("Не верно введены данные");
			}

			BMI pasha = new(weight, height);
			Console.WriteLine($"BMI = {pasha.GetBMI()}");
			#endregion

			#region Sort Array
			int[] array = ArraySort.GetArray(out int min, out int max);

			foreach (int item in array)
			{
				Console.WriteLine(item);
			}

			Console.WriteLine();
			Console.WriteLine($"Максимальный элемент: {max} Минимальный элемент: {min}");
			#endregion

			#region GetMediumLongWord
			Console.Write("Введите текст: ");
			Console.WriteLine(GetMediumLongWord(Console.ReadLine()));
			#endregion
		}

		/// <summary>
		/// Считает среднюю длину слов(без учета символов)
		/// </summary>
		/// <param name="text">Строка</param>
		/// <returns>Среднюю длину</returns>
		private static int GetMediumLongWord(string text)
		{
			string[] strArray = text.Split(' ');
			int sum = 0;

			foreach (string str in strArray)
			{
				foreach (char ch in str)
				{
					if (char.IsLetterOrDigit(ch))
					{
						sum++;
					}
				}
			}
			return sum / strArray.Length;
		}
	}
}
