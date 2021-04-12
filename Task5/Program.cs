using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Text.Json;

namespace Task5
{
	internal class Program
	{
		private static void Main()
		{
			List<Account> listAccounts = new()
			{
				new Account() { AccountId = 1, DateLastEnter = DateTime.Now, Email = "gtefwFassd@norbit.ru", FullName = "Филя Пупкин" },
				new Account() { AccountId = 2, DateLastEnter = new DateTime(2020, 10, 3), Email = "Ar34asd@norbit.ru", FullName = "Геннадий Пупкин" }
			};

			File.WriteAllText(ConfigurationManager.AppSettings.Get("Folder"), JsonSerializer.Serialize(listAccounts, new JsonSerializerOptions() { WriteIndented = true }));
			Account[] accounts = JsonSerializer.Deserialize<Account[]>(File.ReadAllText(ConfigurationManager.AppSettings.Get("Folder")));
			foreach (Account account in accounts)
			{
				Console.WriteLine(account);
			}
		}
	}
}
