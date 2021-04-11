using System.Collections.Generic;
using System.Linq;

namespace Task3
{
	internal class Program
	{
		private static void Main()
		{
			List<string> list = new() { "SAd", "32dtg" };
			list.Add("Sd");
		}

		/// <summary>
		/// Подсчет частоты слов
		/// </summary>
		/// <param name="text"></param>
		/// <returns></returns>
		private static string WordRateCounting(string text)
		{
			List<string> textArray = text.Split(' ', '.').ToList();
			List<string> formatorStringList = new();
			int i;
			foreach (string str in textArray)
			{
				i = 0;
				foreach (string str2 in textArray)
				{
					if (str.ToLower() == str2.ToLower())
					{
						i++;
					}
				}
				formatorStringList.Add($"{str} - {i}\n");
			}

			List<string> filtredStringList = formatorStringList.Distinct().ToList();
			string rStr = null;

			foreach (string str in filtredStringList)
			{
				rStr += str;
			}

			return rStr;
		}
	}
}