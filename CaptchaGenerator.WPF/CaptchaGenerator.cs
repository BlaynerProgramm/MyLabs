using System;
using System.Text;

namespace CaptchaGenerator_WPF
{
	/// <summary>
	/// Каптча генератор
	/// </summary>
	public class CaptchaGenerator
	{
		/// <summary>
		/// Сгенерированная каптча
		/// </summary>
		public string Captcha { get; init; }
		private readonly char[] _symbols = new char[]
		{ 'B', 'C', 'D', 'F', 'G', 'H', 'J', 'K', 'L', 'M', 'N', 'P', 'Q', 'R', 'S', 'T', 'V', 'W', 'X', 'Y', 'Z', 'A', 'E', 'I', 'O', 'U', 'Y', '1', '2', '3', '4', '5', '6', '7', '8', '9', '0' };

		public CaptchaGenerator()
		{
			Random random = new();
			StringBuilder stringBuilder = new();
			for (int i = 0; i < 5; i++)
			{
				stringBuilder.Append(_symbols[random.Next(0, _symbols.Length)]);
			}
			Captcha = stringBuilder.ToString();
		}
	}
}
