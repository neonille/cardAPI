using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Card_api.Models
{
	public class Deck
	{
        public Stack<Deck> Cards { get; set; }
        public Guid Id
    }
}
