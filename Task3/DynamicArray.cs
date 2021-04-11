using System;
using System.Collections;
using System.Collections.Generic;

namespace Task3
{
	public class DynamicArray<T> : IEnumerable, IEnumerable<T>
	{
		/// <summary>
		/// Сам массив
		/// </summary>
		private T[] _array { get; set; }
		/// <summary>
		/// Фактическая длинна
		/// </summary>
		public int Lenght { get; private set; }
		/// <summary>
		/// Объём
		/// </summary>
		public int Capacity { get; private set; }

		public DynamicArray()
		{
			Capacity = 8;
			_array = new T[Capacity];
		}

		/// <summary>
		/// С заданным размером
		/// </summary>
		/// <param name="capacity"></param>
		public DynamicArray(int capacity)
		{
			if (capacity > 0)
			{
				Capacity = capacity;
				_array = new T[Capacity];
			}
			else
			{
				throw new ArgumentException("Не корректные данные");
			}
		}

		public DynamicArray(IEnumerable<T> ts)
		{
			foreach (T item in ts)
			{
				Add(item);
			}
		}

		public T this[int index]
		{
			get => _array[index];
			set => _array[index] = value;
		}

		public IEnumerator GetEnumerator() => _array.GetEnumerator();

		IEnumerator<T> IEnumerable<T>.GetEnumerator() => (IEnumerator<T>)_array.GetEnumerator();
		/// <summary>
		/// Добавление элемента в конец массива
		/// </summary>
		/// <param name="element"></param>
		public void Add(T element)
		{
			if (Lenght >= Capacity)
			{
				ResizeArray();
			}
			Enumeration(Lenght, element);

		}

		/// <summary>
		/// Добавление коллекции в конец массива
		/// </summary>
		/// <param name="collection">Коллекция реализующая IEnumerable<T></param>
		public void AddRange(IEnumerable<T> collection)
		{
			foreach (T item in collection)
			{
				Add(item);
			}
		}
		/// <summary>
		/// Удаление элемента
		/// </summary>
		/// <param name="index"></param>
		/// <returns></returns>
		public bool Remove(int index)
		{
			try
			{
				Enumeration(index);
				Lenght--;
				return true;
			}
			catch
			{
				return false;
			}
		}
		/// <summary>
		/// Замена
		/// </summary>
		/// <param name="index"></param>
		/// <param name="element"></param>
		/// <returns></returns>
		public bool Insert(int index, T element)
		{
			try
			{
				Enumeration(index, element);
				return true;
			}
			catch
			{
				return false;
			}
		}

		#region Вспомогательные методы
		/// <summary>
		/// Перебор и смещение массива
		/// </summary>
		/// <param name="index"></param>
		/// <param name="element"></param>
		private void Enumeration(int index, T element)
		{
			for (int i = index; i < Capacity - 1; i++)
			{
				_array[++i] = _array[i];
			}

			_array[index] = element;
		}
		/// <summary>
		/// Увеличение размера массива
		/// </summary>
		private void ResizeArray()
		{
			int[] temp = new int[Capacity];
			_array.CopyTo(temp, 0);
			_array = new T[++Capacity];
			temp.CopyTo(_array, 0);
		}

		private void Enumeration(int index)
		{
			for (int i = index; i < _array.Length; i++)
			{
				_array[i] = _array[i + 1];
			}
		}
		/// <summary>
		/// Перебор и отсортировка массива
		/// </summary>
		/// <param name="index"></param>
		/// <param name="collection"></param>
		private void Enumeration(int index, IEnumerable<T> collection)
		{
			for (int i = index; i < Capacity - 1; i++)
			{
				_array[++i] = _array[i];
			}

			foreach (T element in collection)
			{
				_array[index++] = element;
			}

		}
		#endregion
	}
}
