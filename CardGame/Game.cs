using System;
using System.Collections.Generic;

namespace CardGame
{
    internal class Game
    {
        List<Player> players;
        List<Card> cardDeck;

        public Game(List<Player> players, List<Card> cards)
        {
            if (players.Count >= 2)
            {
                this.players = players;
                cardDeck = cards;
            }
            else
            {
                throw new Exception();
            }
        }
    }
}
