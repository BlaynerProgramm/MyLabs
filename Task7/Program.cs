namespace Task7
{
	internal class Program
	{
		private static void Main()
		{
			string name;
			string surname;
			string patronymic;
			string age;
			string birthday;

			Round round = new(new System.Drawing.Point(5, 2), 10);
			System.Console.WriteLine($"S = {round.Square()}\nP = {round.Perimeter()}");

			#region Заполнение полей для пользователя
			System.Console.Write("Введите имя для пользователя: ");
			name = System.Console.ReadLine();
			System.Console.Write("Введите фамилию для пользователя: ");
			surname = System.Console.ReadLine();
			System.Console.Write("Введите отчество для пользователя: ");
			patronymic = System.Console.ReadLine();
			System.Console.Write("Введите возраст для пользователя: ");
			age = System.Console.ReadLine();
			System.Console.Write("Введите дату рождения для пользователя: ");
			birthday = System.Console.ReadLine();
			#endregion
			User newUser = new(surname, name, patronymic, birthday, age);

			System.Console.WriteLine(newUser);
		}
	}
}
