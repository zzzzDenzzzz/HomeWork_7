using System;
using System.Collections.Generic;

namespace CardGame
{
    internal class Player
    {
        public string Name { get; set; }
        List<Card> currentCards;

        public Player(string name)
        {
            Name = name;
        }

        public void ShowCards()
        {
            foreach (Card card in currentCards)
            {
                card.Show();
                Console.Write(" ");
            }
        }
    }
}
