using LinqToDB.Mapping;

using System;

namespace Task12.Api.Models
{
	[Table(Name = "User")]
	public class User
	{
		[Column(IsPrimaryKey = true)]
		public Guid Id { get; set; }
		[Column(Name = "UserDomainName")]
		public string UserDomainName { get; set; }
	}
}
