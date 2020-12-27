using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Card_api.Models;

namespace Card_api.Controllers
{
	public class DeckController : Controller
	{
		[HttpGet]
		[Route("new")]
		public async Task<IActionResult> New(string text)
		{
			Card_api.Services.JwtService.JwtService js = new Services.JwtService.JwtService();
			var f = js.NewSession();
			return Ok(f);

			//DeckFactory deckFactory = new DeckFactory();
			//Stack<Card> c = deckFactory.InitDeck();
			//return c;
		}
	}
}
