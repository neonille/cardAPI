using System;
using Card_api.Models;

namespace Card_api.Services
{
    public class CardService
    {
        public CardService()
        {
        }

        public int CheckWorth(Rank rank, Game game)
        {
			if(game.Equals(Game.Baccarat))
			{
				int value = (int)rank + 1;
				if (value > 9) value = 0;
				return value;
			}
			else if (game.Equals(Game.BlackJack))
			{
				int value = (int)rank + 1;
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
