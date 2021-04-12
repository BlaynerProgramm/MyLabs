using LinqToDB;

using System;
using System.Collections.Generic;
using System.Linq;

namespace Task10
{
	internal class Linq2DbConnection
	{
		public static List<Guid> GetStudent()
		{
			string connectionString = @"Server=DESKTOP-25EV0KI\DEV;Database=College_Db;Trusted_Connection=True;";
			List<Guid> students = new();
			using (DataContext context = new(connectionString))
			{
				IQueryable<Guid> query = context.GetTable<Students>().Where(x => x.Name == "Kirill").Select(x => x.Id);
				students.AddRange(query);
			}
			return students;
		}
	}
}