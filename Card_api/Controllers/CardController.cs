﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Card_api.Controllers
{
	public class CardController : Controller
	{
		public IActionResult Index()
		{

			return View();
		}
	}
}
