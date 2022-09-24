using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame
{
    internal class Game
    {
        List<Player> players;
        List<Card> cardDeck;

        public Game(List<Player> players)
        {
            this.players = players;
            cardDeck = new List<Card>();

            var cardHeartsAce = new Card(3, true, "A");
            var cardDiamondsAce = new Card(4, true, "A");
            var cardClubsAce = new Card(5, false, "A");
            var cardSpadesAce = new Card(6, false, "A");

            cardDeck.Add(cardHeartsAce);
            cardDeck.Add(cardDiamondsAce);
            cardDeck.Add(cardClubsAce);
            cardDeck.Add(cardSpadesAce);
        }
    }
}
