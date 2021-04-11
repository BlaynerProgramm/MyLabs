using System;

namespace Task2
{
	public class BMI
	{
		/// <summary>
		/// Вес
		/// </summary>
		public int Weight { get; init; }
		/// <summary>
		/// Рост
		/// </summary>
		public double Height { get; init; }

		public BMI(int weight, double height)
		{
			if (weight <= 0 || height <= 0)
			{
				throw new ArgumentException("Не корректные данные");
			}

			Weight = weight;
			Height = height;
		}
		/// <summary>
		/// Рассчитать Индекс массы тела
		/// </summary>
		/// <returns>ИМТ</returns>
		public double GetBMI() => Weight / Math.Pow(Height, 2);
	}
}
