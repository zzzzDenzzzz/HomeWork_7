using System;
using System.Collections.Generic;

namespace CardGame
{
    internal class CardDeck
    {
        string[] suit = { "diamonds", "hearts", "clubs", "spades" };
        string[] rank = { "6", "7", "8", "9", "10", "J", "Q", "K", "A" };
        List<Card> cardDeck;

        public CardDeck()
        {
            cardDeck = new List<Card>();
            for (int i = 0; i < suit.Length; i++)
            {
                for (int j = 0; j < rank.Length; j++)
                {
                    cardDeck.Add(new Card(suit[i], rank[j]));
                }
            }
        }

        public void Shuffle()
        {
            Random rand = new Random();

            for (int i = cardDeck.Count - 1; i >= 1; i--)
            {
                int j = rand.Next(i + 1);

                Card tmp = cardDeck[j];
                cardDeck[j] = cardDeck[i];
                cardDeck[i] = tmp;
            }
        }

        public List<Card> GetCardDeck()
        {
            return cardDeck;
        }
    }
}
