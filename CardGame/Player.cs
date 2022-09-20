using System;
using System.Collections.Generic;

namespace CardGame
{
    internal class Player
    {
        List<Card> cards;

        public Player(List<Card> cards)
        {
            this.cards = cards;
        }

        public void ShowCards()
        {
            foreach (Card card in cards)
            {
                card.Show();
                Console.Write(" ");
            }
        }
    }
}
