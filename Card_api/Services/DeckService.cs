using System;
using System.Collections.Generic;
using Card_api.Models;

namespace Card_api.Services
{
    public class DeckService
    {
		CardService _cardService; 
        public DeckService()
        {
			_cardService = new CardService();
        }

        public Deck FillDeck(Deck deck)
        {
			deck.Cards = new Stack<Card>();
			Suite[] suites = (Suite[])Enum.GetValues(typeof(Suite));
			Rank[] ranks = (Rank[])Enum.GetValues(typeof(Rank));
			foreach (Suite suit in suites)
			{
				foreach (Rank rank in ranks)
				{
					Card card = new Card();
					card.Suite = suit;
					card.Rank = rank;
					card.Worth = _cardService.CheckWorth(rank,Game.Baccarat);
					deck.Cards.Push(card);
				}
			}
			return deck;
		}
    }
}
