namespace Task11.Models
{
	public class Student
	{
		public string Surname { get; set; }
		public string Name { get; set; }
		public string Patronomic { get; set; }

		public override string ToString() => $"{Surname} {Name} {Patronomic}";
	}
}
