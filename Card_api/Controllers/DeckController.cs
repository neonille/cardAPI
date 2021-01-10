using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Casino_api.Models;
using Microsoft.Extensions.Configuration;
using Casino_api.Services;

namespace Casino_api.Controllers
{
	public class DeckController : Controller
	{
		public IConfiguration _config;

		public DeckController(IConfiguration config)
		{
			_config = config;
		}

		[HttpGet]
		[Route("new")]
		public async Task<IActionResult> New(string text)
		{

			DeckService ds = new DeckService();
			Deck d = new Deck();
			ds.FillDeck(d, false);
			return Ok(ds.Shuffle(d));

			//DeckFactory deckFactory = new DeckFactory();
			//Stack<Card> c = deckFactory.InitDeck();
			//return c;
		}
	}
}
