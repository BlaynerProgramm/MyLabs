using System;
using System.Text;

namespace Task1
{
	/// <summary>
	/// Квадрат
	/// </summary>
	public class Square
	{
		public int SideOfSquare { get; init; }
		public Square(int n)
		{
			if (n <= 0)
			{
				throw new ArgumentException("Введите валидное число");
			}
			if (n % 2 == 0)
			{
				throw new ArgumentException("Введите не четное число");
			}
			SideOfSquare = n;
		}
		/// <summary>
		/// Нарисовать квадрат звёздочками без середины
		/// </summary>
		/// <returns></returns>
		public string DrowSquare()
		{
			StringBuilder sb = new();
			for (int i = 0; i <= SideOfSquare - 1; i++)
			{
				for (int j = 0; j <= SideOfSquare - 1; j++)
				{

					if (i == SideOfSquare / 2 && j == SideOfSquare / 2)
					{
						sb.Append(' ');
						continue;
					}
					sb.Append('*');
				}
				sb.Append('\n');
			}

			return sb.ToString();
		}
	}
}
