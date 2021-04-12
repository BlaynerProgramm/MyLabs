using LinqToDB;

using Microsoft.AspNetCore.Mvc;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;

using Task12.Api.Models;

namespace Task12.Api.Controllers
{
	[ApiController]
	[Route("[controller]")]
	public class DealController : Controller
	{
		[HttpGet]
		public string Amount()
		{
			List<Entity> entityList = new();
			string userDN = Environment.UserDomainName;
			try
			{
				using (DataContext context = new(@"DESKTOP-25EV0KI\DEV;Initial Catalog=LEARN_training01;Trusted_Connection=True;"))
				{
					Guid queryUser = context.GetTable<User>()
						.Where(x => x.UserDomainName == userDN)
						.Select(x => x.Id).First();

					IQueryable<string> queryData = context.GetTable<Data>()
						.Where(x => x.UserId == queryUser)
						.Select(x => x.Entity);

					foreach (string i in queryData)
					{
						entityList.Add(JsonSerializer.Deserialize<Entity>(i));
					}
				}
				return JsonSerializer.Serialize(entityList.OrderByDescending(x => x.Created).First());
			}
			catch
			{
				throw new InvalidOperationException();
			}
		}
	}
}
