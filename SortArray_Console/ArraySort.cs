using System;
using System.Text;

namespace SortArray_Console
{
	/// <summary>
	/// Сортировка массива
	/// </summary>
	public class ArraySort
	{
		/// <summary>
		/// Массив
		/// </summary>
		private double[] _arrayDouble { get; init; }

		public ArraySort(int seed, int size)
		{
			if (size <= 0)
			{
				throw new ArgumentException("Введите корректное значение");
			}
			_arrayDouble = GenerateRandomDoubleArray(seed, size);
		}

		/// <summary>
		/// Заполнение массива
		/// </summary>
		/// <param name="seed"></param>
		/// <param name="size">Размер массива</param>
		/// <returns>Заполненый массив</returns>
		public static double[] GenerateRandomDoubleArray(int seed, int size)
		{
			Random rand = new(seed);
			double[] a = new double[size];
			for (int i = 0; i < size; i++)
			{
				a[i] = Math.Round(rand.Next(-1, 2) * rand.NextDouble() * 100, 2);
			}
			return a;
		}

		/// <summary>
		/// Получение минимального значения
		/// </summary>
		/// <returns>Минимальное значение</returns>
		public double GetMin()
		{
			double min = _arrayDouble[0];
			for (int i = 1; i < _arrayDouble.Length; i++)
			{
				if (_arrayDouble[i] < min)
				{
					min = _arrayDouble[i];
				}
			}
			return min;
		}

		/// <summary>
		/// Сумма положительных элементов
		/// </summary>
		/// <returns>Сумму</returns>
		public double SumElements()
		{
			double sum = 0;
			for (int i = 0; i < _arrayDouble.Length; i++)
			{
				if (_arrayDouble[i] > 0)
				{
					sum += _arrayDouble[i];
				}
			}
			return sum;
		}

		/// <summary>
		/// Сортировка массива
		/// </summary>
		public void SortArray()
		{
			for (int i = 0; i < _arrayDouble.Length; i++)
			{
				for (int j = i + 1; j < _arrayDouble.Length; j++)
				{
					if (Math.Abs(_arrayDouble[i]) > Math.Abs(_arrayDouble[j]))
					{
						double temp = _arrayDouble[i];
						_arrayDouble[i] = _arrayDouble[j];
						_arrayDouble[j] = temp;
					}
				}
			}
		}

		public override string ToString()
		{
			StringBuilder sb = new();
			foreach (double element in _arrayDouble)
			{
				sb.Append($"{element}\n");
			}
			return sb.ToString();
		}
	}
}
