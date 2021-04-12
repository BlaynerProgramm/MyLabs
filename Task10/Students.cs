using LinqToDB.Mapping;

using System;

namespace Task10
{
	[Table(Name = "Students")]
	public class Students
	{
		[Column(IsPrimaryKey = true)]
		public Guid Id { get; set; }
		[Column(Name = "Surname")]
		public string Surname { get; set; }
		[Column(Name = "Name")]
		public string Name { get; set; }
		[Column(Name = "Patronomic")]
		public string Patronomic { get; set; }

		public override string ToString() => $"{Surname} {Name} {Patronomic}";
	}
}