using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Casino_api.Models
{
	public class Deck
	{
        public Stack<Card> Cards { get; set; }
        public Guid Id { get; set; }
        public string Creator { get; set; }
    }
}
