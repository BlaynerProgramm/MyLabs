using System.Collections.Generic;
using System.Data.SqlClient;

namespace Task10
{
	internal class AdoNetConnection
	{
		public static List<Students> GetStudent()
		{
			string queryString = "SELECT Surname, Name, Patronomic FROM Students WHERE Is_Orphant = 0";
			string connectionString = @"Server=DESKTOP-25EV0KI\DEV;Database=College_Db;Trusted_Connection=True;";
			List<Students> students = new();
			using (SqlConnection connection = new(connectionString))
			{
				SqlCommand command = new(queryString, connection);
				connection.Open();
				SqlDataReader reader = command.ExecuteReader();
				while (reader.Read())
				{
					students.Add(new Students() { Name = (string)reader[1], Patronomic = (string)reader[2], Surname = (string)reader[0] });
				}
			}
			return students;
		}
	}
}