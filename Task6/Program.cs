using System;
using System.Collections.Generic;
using System.Linq;

namespace Task6
{
	internal class Program
	{
		private static void Main()
		{
			List<Person> listPersons = new List<Person>()
			{
				new Person(){Name = "Kirill", Age = 19},
				new Person(){Name = "Andrew", Age = 20},
				new Person(){Name = "July", Age = 19},
				new Person(){Name = "Nik", Age = 17},
				new Person(){Name = "Loly", Age = 18},
				new Person(){Name = "Artem", Age = 17}
			};
			Console.WriteLine("Сгруппированы по возрасту:");
			foreach (IGrouping<int, Person> item in Person.GroupPeopleByAge(listPersons))
			{
				Console.WriteLine(item.Key);
				foreach (Person item2 in item)
				{
					Console.WriteLine(item2.Name);
				}
				Console.WriteLine();
			}

			Console.WriteLine("Отсортированные по возрастанию:");
			foreach (Person i in Person.OrderByAgePeaple(listPersons))
			{
				Console.WriteLine(i + "\n");
			}
		}
	}
}
