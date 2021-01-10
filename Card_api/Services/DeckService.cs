using System;
using System.Collections.Generic;
using Casino_api.Models;

namespace Casino_api.Services
{
    public class DeckService
    {
		CardService _cardService; 
        public DeckService()
        {
			_cardService = new CardService();
        }

        public Deck FillDeck(Deck deck, bool joker)
        {
			deck.Cards = new Stack<Card>();
			Suite[] suites = (Suite[])Enum.GetValues(typeof(Suite));
			Rank[] ranks = (Rank[])Enum.GetValues(typeof(Rank));
			if(!joker) Array.Resize(ref ranks, ranks.Length -1);
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

		public string Shuffle(Deck deck)
		{
			Card[] cardTemp = new Card[deck.Cards.Count];
			int count = 0;
			while (deck.Cards.Count > 0)
			{
				cardTemp[count] = deck.Cards.Pop();
				count++;
			}
			return "";
		}
    }
}
