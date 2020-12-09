using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Card_api.Controllers
{
	public class DeckController : Controller
	{
		[HttpGet]
		[Route("new")]
		public ActionResult<Stack<Models.Card>> New(string text)
		{
			Factories.DeckFactory df = new Factories.DeckFactory();
			Stack<Models.Card> c = df.CreateDeck();
			return c;
		}
	}
}
