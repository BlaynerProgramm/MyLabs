namespace Task3
{
	public class Person
	{
		public string Name { get; set; }

		public override bool Equals(object peopleObj)
		{
			Person person = (Person)peopleObj;
			return person.Name == Name;
		}
		public override int GetHashCode() => Name.GetHashCode();
	}
}
