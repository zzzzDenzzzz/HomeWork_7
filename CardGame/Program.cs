using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var cardHeartsAce = new Card(3, true, "A");
            var cardDiamondsAce = new Card(4, true, "A");
            var cardClubsAce = new Card(5, false, "A");
            var cardSpadesAce = new Card(6, false, "A");

            var cardDeck = new List<Card>();
            cardDeck.Add(cardHeartsAce);
            cardDeck.Add(cardDiamondsAce);
            cardDeck.Add(cardClubsAce);
            cardDeck.Add(cardSpadesAce);

            var player = new Player(cardDeck);
            player.ShowCards();
        }
    }
}
