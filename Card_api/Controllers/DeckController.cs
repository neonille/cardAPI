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
		[Route("asd")]
		public ActionResult<string> New(string text)
		{

			return text +" 000 ";
		}
	}
}
