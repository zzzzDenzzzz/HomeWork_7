using System.Collections.Generic;

namespace CardGame
{
    internal class Game
    {
        List<Player> players;
        List<Card> cardDeck;

        public Game(List<Player> players)
        {
            this.players = players;
        }
    }
}
