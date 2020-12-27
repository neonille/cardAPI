using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Card_api.Models
{
	public class Deck
	{
        public Stack<Card> Cards { get; set; }
        public Guid Id { get; set; }
        public string creator { get; set; }
    }
}
