using System;

namespace Task10
{
	internal class Program
	{
		private static void Main()
		{
			foreach (Students stud in AdoNetConnection.GetStudent())
			{
				Console.WriteLine($"AdoNet : {stud}");
			}
			Linq2DbConnection connection = new();
			foreach (Guid studGuid in Linq2DbConnection.GetStudent())
			{
				Console.WriteLine($"Linq2Db : {studGuid}");
			}
		}
	}
}
