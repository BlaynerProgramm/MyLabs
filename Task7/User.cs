using System;

namespace Task7
{
	/// <summary>
	/// Пользователь
	/// </summary>
	public class User
	{
		#region Свойства
		/// <summary>
		/// Фамилия.
		/// </summary>
		public string Surname { get; private set; }
		/// <summary>
		/// Имя.
		/// </summary>
		public string Name { get; private set; }
		/// <summary>
		/// Отчество.
		/// </summary>
		public string Patronymic { get; private set; }
		/// <summary>
		/// Дата рождения.
		/// </summary>
		public DateTime Birthday { get; private set; }
		/// <summary>
		/// Возраст.
		/// </summary>
		public int Age { get; private set; }
		#endregion

		/// <summary>
		/// Проверяет и задаёт свойства для пользователя.
		/// </summary>
		/// <param name="surname">Фамилия</param>
		/// <param name="name">Имя</param>
		/// <param name="patronymic">Отчество</param>
		/// <param name="birthday">Дата рождения</param>
		/// <param name="age">Возраст</param>
		public User(string surname, string name, string patronymic, string birthday, string age)
		{
			if (string.IsNullOrEmpty(name))
			{
				throw new ArgumentException("Введите верные данные");
			}

			if (string.IsNullOrEmpty(surname))
			{
				throw new ArgumentException("Введите верные данные");
			}

			if (string.IsNullOrEmpty(patronymic))
			{
				throw new ArgumentException("Введите верные данные");
			}

			if (int.TryParse(age, out int result))
			{
				Age = result;
			}
			else
			{
				throw new ArgumentException("Введите верные данные");
			}

			if (DateTime.TryParse(birthday, out DateTime date))
			{
				Birthday = date;
			}
			else
			{
				throw new ArgumentException("Введите верные данные");
			}
			Name = name;
			Surname = surname;
			Patronymic = patronymic;
		}

		public override string ToString() => $"{Surname} {Name} {Patronymic}";
	}
}