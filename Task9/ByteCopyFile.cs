using System;
using System.IO;

namespace Task9
{
	internal class ByteСopyFile
	{
		public delegate void StatusOfCopying(string message);
		public event StatusOfCopying Start;
		public event StatusOfCopying End;
		public event StatusOfCopying Progress;
		/// <summary>
		/// Имя исходного файла.
		/// </summary>
		public string NameFile { get; init; }
		/// <summary>
		/// Имя конечного файла.
		/// </summary>
		public string NameFinalFile { get; init; }
		/// <summary>
		/// Размер блока.
		/// </summary>
		public int SizeBlock { get; init; }

		public ByteСopyFile(string nameFile, string nameFinalFile, int sizeBlock)
		{
			if (string.IsNullOrEmpty(nameFile))
			{
				throw new ArgumentException("Введите валидные данные");
			}
			if (string.IsNullOrEmpty(nameFinalFile))
			{
				throw new ArgumentException("Введите валидные данные");
			}
			if (sizeBlock <= 0)
			{
				throw new ArgumentException("Введите валидные данные");
			}

			NameFile = nameFile;
			NameFinalFile = nameFinalFile;
			SizeBlock = sizeBlock;
		}

		/// <summary>
		/// Копирование
		/// </summary>
		public void Copy()
		{
			Start?.Invoke("Копирование началось");
			using (FileStream fileStream = new(NameFinalFile, FileMode.OpenOrCreate))
			{
				byte[] arrayByte = File.ReadAllBytes(NameFile);
				fileStream.Write(arrayByte, SizeBlock, arrayByte.Length);
				Progress?.Invoke(fileStream.ReadTimeout.ToString());
			}
			End?.Invoke("Копирование закончилось");
		}

		/// <summary>
		/// Копирование в конец файла
		/// </summary>
		public void CopyEnd()
		{
			Start?.Invoke("Копирование началось");
			using (StreamWriter stream = new(NameFinalFile, true))
			{
				string text = File.ReadAllText(NameFile);
				stream.WriteLine(text);
			}
			End?.Invoke("Копирование закончилось"); //TODO: Написать проверки
		}

		public string ReadText()
		{
			StreamReader stream = new(NameFinalFile);
				return stream.ReadToEnd();
		}
	}
}
