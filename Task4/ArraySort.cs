namespace Task4
{
	internal class ArraySort
	{
		/// <summary>
		/// Сравнение указанных типов
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="a"></param>
		/// <param name="b"></param>
		/// <returns></returns>
		public delegate bool Сompare<T>(T a, T b);
		/// <summary>
		/// Делегат для события EndSort
		/// </summary>
		/// <param name="message"></param>
		public delegate void MessageArray(string message);

		/// <summary>
		/// Сортировка методом пузырька
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="array">Массив</param>
		/// <param name="comparer">Метод сравнения</param>
		public static void Sort<T>(T[] array, Сompare<T> comparer)
		{
			for (int i = 0; i < array.Length; i++)
			{
				for (int j = i + 1; j < array.Length; j++)
				{
					if (!comparer(array[j], array[i]))
					{
						T temp = array[i];
						array[i] = array[j];
						array[j] = temp;
					}
				}
			}
		}

		/// <summary>
		/// Сравнение чисел
		/// </summary>
		/// <param name="a"></param>
		/// <param name="b"></param>
		/// <returns>true - если a > b</returns>
		public static bool IntСompare(int a, int b) => a > b;


		/// <summary>
		/// Сравнение строк
		/// </summary>
		/// <param name="a"></param>
		/// <param name="b"></param>
		/// <returns>true - если a > b</returns>
		public static bool StringСompare(string a, string b) => a.Length > b.Length;
	}
}
