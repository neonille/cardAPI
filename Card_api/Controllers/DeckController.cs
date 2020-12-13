using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Card_api.Factories;
using Card_api.Models;

namespace Card_api.Controllers
{
	public class DeckController : Controller
	{
		[HttpGet]
		[Route("new")]
		public ActionResult<Stack<Models.Card>> New(string text)
		{
			DeckFactory deckFactory = new DeckFactory();
			Stack<Card> c = deckFactory.InitDeck();
			return c;
		}
	}
}
