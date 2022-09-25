using System;
using System.Collections.Generic;

namespace CardGame
{
    internal class Game
    {
        List<Player> players;
        CardDeck cardDeck;
        List<Card> table;

        public Game(CardDeck cardDeck, params Player[] players)
        {
            if (players.Length >= 2 && cardDeck.GetCardDeck().Count % players.Length == 0)
            {
                this.players = new List<Player> { };
                this.players.AddRange(players);
                this.cardDeck = cardDeck;
                table = new List<Card>();
            }
            else
            {
                throw new Exception();
            }
        }

        public void DealingCards()
        {
            int count = cardDeck.GetCardDeck().Count / players.Count;

            for (int i = 0; i < players.Count; i++)
            {
                for (int j = 0; j < count; j++)
                {
                    players[i].AddCard(cardDeck.GetCardDeck()[j]);
                }
                cardDeck.GetCardDeck().RemoveRange(0, count);
            }
        }

        public void PutCards()
        {
            for (int i = 0; i < players.Count; i++)
            {
                table.Add(players[i].PutCard());
            }
            for (int i = 0; i < table.Count; i++)
            {
                table[i].Show();
            }
        }

        public void ShowCardsInPlayer()
        {
            for (int i = 0; i < players.Count; i++)
            {
                players[i].ShowCards();
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        public void PlayerTakesCards()
        {
            for (int i = 0; i < players.Count; i++)
            {

            }
            table.Clear();
        }
    }
}
