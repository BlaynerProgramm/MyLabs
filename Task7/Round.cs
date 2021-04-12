using System;
using System.Drawing;

namespace Task7
{
	public class Round
	{
		/// <summary>
		/// Центр.
		/// </summary>
		public Point Centre { get; private set; }
		/// <summary>
		/// Радиус.
		/// </summary>
		public int Radius { get; private set; }

		/// <summary>
		/// Проверяет и задаёт значения для свойств.
		/// </summary>
		/// <param name="centre">Центр окружности</param>
		/// <param name="r">Радиус окружности</param>
		public Round(Point centre, int r)
		{
			if (centre.X < 0 && centre.Y < 0)
			{
				throw new ArgumentException("Не корректное значение");
			}

			if (r < 0)
			{
				throw new ArgumentException("Не корректное значение");
			}
			Radius = r;
			Centre = centre;
		}

		public double Square() => Math.PI / Radius * Radius;
		public double Perimeter() => 2 * Math.PI * Radius;
	}
}