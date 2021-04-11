using System;

namespace Task2
{
	/// <summary>
	/// Сортировка массива
	/// </summary>
	internal class ArraySort
	{
		/// <summary>
		/// Получить заполненный массив
		/// </summary>
		/// <param name="arrayMin">Минимальный элемент массива</param>
		/// <param name="arrayMax">Максимальный элемент массива</param>
		/// <returns></returns>
		public static int[] GetArray(out int arrayMin, out int arrayMax)
		{
			arrayMax = 0;
			int[] array = new int[5];

			FillingArray(array);
			SortArray(ref arrayMax, array);
			arrayMin = array[0];

			return array;
		}

		/// <summary>
		/// Сортировка массива и нахождение максимального элемента
		/// </summary>
		/// <param name="arrayMax">Максимальный элемент массива</param>
		/// <param name="array">Массив</param>
		private static void SortArray(ref int arrayMax, int[] array)
		{
			int temp;
			for (int i = 0; i < array.Length; i++)
			{
				for (int j = i + 1; j < array.Length; j++)
				{
					if (array[i] > array[j])
					{
						temp = array[i];
						array[i] = array[j];
						array[j] = temp;
					}
				}
				arrayMax = array[i];
			}
		}

		/// <summary>
		/// Заполнение массива
		/// </summary>
		/// <param name="array">Массив</param>
		private static void FillingArray(int[] array)
		{
			Random random = new();

			for (int i = 0; i < array.Length; i++)
			{
				array[i] = random.Next(0, 100);
			}
		}
	}
}