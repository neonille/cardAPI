using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Casino_api.Models;

namespace Casino_api.Data
{
	public class Decks
	{
		public static ConcurrentDictionary<string, Deck> decks;
	}
}
