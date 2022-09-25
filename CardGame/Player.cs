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
            currentCards = new List<Card>();
        }

        public void ShowCards()
        {
            foreach (Card card in currentCards)
            {
                card.Show();
                Console.Write(" ");
            }
        }

        public void AddCard(Card card)
        {
            currentCards.Add(card);
        }

        public Card PutCard()
        {
            Card tmp = currentCards[0];
            currentCards.RemoveAt(0);

            return tmp;
        }

        public int CountCurrentCard()
        {
            return currentCards.Count;
        }
    }
}
