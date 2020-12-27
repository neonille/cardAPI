using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Card_api.Models;

namespace Card_api.Data
{
	public class Decks
	{
		public static ConcurrentDictionary<string, Deck> decks;
	}
}
