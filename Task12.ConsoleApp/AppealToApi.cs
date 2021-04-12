using System.IO;
using System.Net;
using System.Text.Json;

namespace Task12.ConsoleApp
{
	/// <summary>
	/// Класс для обращения к Api
	/// </summary>
	public class AppealToApi
	{
		/// <summary>
		/// Получить последнюю сделку
		/// </summary>
		/// <returns></returns>
		public static Entity GetResponseApi()
		{
			try
			{
				WebRequest request = WebRequest.Create("https://localhost:44358/Deal/Amount");
				WebResponse response = request.GetResponse();
				Entity entity = new();
				using (StreamReader reader = new(response.GetResponseStream()))
				{
					entity = JsonSerializer.Deserialize<Entity>(reader.ReadToEnd());
				}
				return entity;
			}
			catch
			{
				throw new WebException("Соединение не удалось");
			}
		}
	}
}