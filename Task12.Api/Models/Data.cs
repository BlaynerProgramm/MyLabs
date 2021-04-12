using LinqToDB.Mapping;

using System;

namespace Task12.Api.Models
{
	[Table(Name = "Data")]
	public class Data
	{
		[Column(IsPrimaryKey = true)]
		public Guid Id { get; set; }
		[Column(Name = "UserId")]
		public Guid UserId { get; set; }
		[Column(Name = "Entity")]
		public string Entity { get; set; }
	}
}
