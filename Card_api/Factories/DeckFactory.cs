using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Card_api.Models;

namespace Card_api.Factories
{
	public class DeckFactory
	{
		public DeckFactory()
		{
			Stack<Card> deck = new Stack<Card>();
			Suite[] suites = (Suite[]) Enum.GetValues(typeof(Suite));
			Rank[] ranks =(Rank[]) Enum.GetValues(typeof(Rank));
			foreach (Suite suit in suites)
			{
				foreach (Rank rank in ranks)
				{
					Card card = new Card();
					card.Suite = suit;
					card.Rank = rank;
					deck.Push(card);
				}
			}
		}

		public Stack<Card> CreateDeck()
		{
			Stack<Card> deck = new Stack<Card>();
			Suite[] suites = (Suite[])Enum.GetValues(typeof(Suite));
			Rank[] ranks = (Rank[])Enum.GetValues(typeof(Rank));
			foreach (Suite suit in suites)
			{
				foreach (Rank rank in ranks)
				{
					Card card = new Card();
					card.Suite = suit;
					card.Rank = rank;
					card.Worth = GetWorth(rank, Game.Baccarat);
					deck.Push(card);
				}
			}
			return deck;
		}

		//It's important that the cards enum is in the correct order (ace first)
		public int GetWorth(Rank rank, Game game)
		{
			if (game.Equals(Game.Baccarat))
			{
				int value = (int)rank+1;
				if (value > 9) value = 0;
				return value;
			} 
			else if (game.Equals(Game.BlackJack))
			{
				int value = (int)rank+1;
				if (value.Equals(1)) return 11;
				else if (value > 10) return 10;
				else return value;
			} 
			else
			{
				throw new Exception("Game not supported");
			}
		}
	}
}
