using System.Text;

namespace Task1
{
	/// <summary>
	/// Разложение числа
	/// </summary>
	internal class DisintedNumber
	{
		/// <summary>
		/// Раскладывает число
		/// </summary>
		/// <param name="n">Число, которое нужно разложить</param>
		/// <returns>Форматированную строку с результатом</returns>
		public static string DecomposeNumber(int n)
		{
			if (n <= 0)
			{
				return "Введите валидное значение";
			}

			StringBuilder str = new($"N = {n}:");
			for (int i = 1; i <= n; i++)
				str.Append($" {i},");

			return str.ToString();
		}
	}
}