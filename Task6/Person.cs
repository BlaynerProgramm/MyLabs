using System.Collections.Generic;
using System.Linq;

namespace Task6
{
	internal class Person
	{
		/// <summary>
		/// Имя.
		/// </summary>
		public string Name { get; set; }
		/// <summary>
		/// Возраст.
		/// </summary>
		public int Age { get; set; }

		/// <summary>
		/// Сортировать возраст по убыванию 
		/// </summary>
		/// <param name="peoples"></param>
		/// <returns></returns>
		public static IEnumerable<Person> OrderByAgePeaple(IEnumerable<Person> peoples) =>
			peoples.OrderByDescending(x => x.Age);

		/// <summary>
		/// Сгруппировать по возрасту
		/// </summary>
		/// <param name="peoples"></param>
		/// <returns></returns>
		public static IEnumerable<IGrouping<int, Person>> GroupPeopleByAge(IEnumerable<Person> peoples)
		{
			return from p in peoples
				   group p by p.Age;
		}

		/// <summary>
		/// Отфильтровать только совершеннолетних
		/// </summary>
		/// <param name="peoples">Коллекция</param>
		/// <returns></returns>
		public static IEnumerable<Person> FiltringAdventurePeoples(IEnumerable<Person> peoples) =>
			peoples.Where(x => x.Age >= 18);

		/// <summary>
		/// Найти в списке по имени
		/// </summary>
		/// <param name="people">Коллекция</param>
		/// <param name="name">Имя, которое вы хотите найти</param>
		/// <returns></returns>
		public static Person FindPeole(IEnumerable<Person> people, string name) =>
			people.First(x => x.Name == name);

		public override string ToString() => Name + ' ' + Age;
	}
}