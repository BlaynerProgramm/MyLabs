using Microsoft.AspNetCore.Mvc;

using Newtonsoft.Json;

using System.Collections.Generic;
using System.Data.SqlClient;

using Task11.Models;

namespace Task11.Controllers
{
	[ApiController]
	[Route("[controller]")]
	public class StudentController : Controller
	{
		[HttpGet]
		public string Index()
		{
			string queryString = "SELECT Surname, Name, Patronomic FROM Students WHERE Is_Orphant = 0";
			string connectionString = @"Server=DESKTOP-25EV0KI\DEV;Database=College_Db;Trusted_Connection=True;";
			List<Student> students = new();
			using (SqlConnection connection = new(connectionString))
			{
				SqlCommand command = new(queryString, connection);
				connection.Open();
				SqlDataReader reader = command.ExecuteReader();
				while (reader.Read())
				{
					students.Add(new Student() { Name = (string)reader[1], Patronomic = (string)reader[2], Surname = (string)reader[0] });
				}
			}
			return JsonConvert.SerializeObject(students);
		}
		[HttpDelete]
		public void Delete()
		{
			string queryString = "DELETE Students WHERE Is_Orphant = 1";
			string connectionString = @"Server=DESKTOP-25EV0KI\DEV;Database=College_Db;Trusted_Connection=True;";
			List<Student> students = new();
			SqlConnection connection = new(connectionString);
			SqlCommand command = new(queryString, connection);
			connection.Open();
			SqlDataReader reader = command.ExecuteReader();
			while (reader.Read())
			{
				students.Add(new Student() { Name = (string)reader[1], Patronomic = (string)reader[2], Surname = (string)reader[0] });
			}
		}
	}
}
