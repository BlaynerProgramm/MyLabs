using System;

namespace Task2
{
	internal struct Animal
	{
		public string Name { get; set; }
		public int Age { get; set; }

		/// <summary>
		/// Прибавить возраст
		/// </summary>
		/// <param name="num">на сколько</param>
		/// <returns></returns>
		public int AgePlus(int num) => Age + num;

		/// <summary>
		/// Изменить имя
		/// </summary>
		/// <param name="name">На какое имя изменить</param>
		public void NameChange(ref string name) => name = Name;

		/// <summary>
		/// Отнять возраст
		/// </summary>
		/// <param name="num"></param>
		/// <param name="result"></param>
		/// <returns></returns>
		public string AgeSubtract(int num, out int result)
		{
			result = Age - num;
			GC.Collect();
			return "Изменения прошли успешно";
		}
	}
}
