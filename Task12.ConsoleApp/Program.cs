using System;
using System.Net;

namespace Task12.ConsoleApp
{
	internal class Program
	{
		private static void Main()
		{
			Console.Title = $"Последняя сделка {Environment.UserDomainName}";
			Entity response = new();
			try
			{
				response = AppealToApi.GetResponseApi();
			}
			catch (WebException ex)
			{
				Console.WriteLine(ex.ToString());
				return;
			}
			Console.WriteLine("Последняя сделка");
			Console.WriteLine($"Дата : {response.Created.ToLocalTime()}\nСумма = {response.Amount}");
			Console.ReadKey();
		}
	}
}
