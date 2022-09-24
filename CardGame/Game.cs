using System;
using System.Collections.Generic;

namespace CardGame
{
    internal class Game
    {
        List<Player> players;
        CardDeck cardDeck;

        public Game(List<Player> players, CardDeck cardDeck)
        {
            if (players.Count >= 2)
            {
                this.players = players;
                this.cardDeck = cardDeck;
            }
            else
            {
                throw new Exception();
            }
        }
    }
}
