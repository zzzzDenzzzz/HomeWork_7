using System;
using System.Collections.Generic;

namespace CardGame
{
    internal class Game
    {
        List<Player> players;
        CardDeck cardDeck;
        List<Card> table;
        public int Step { get; set; }

        public Game(CardDeck cardDeck, int step, params Player[] players)
        {
            if (players.Length >= 2 && cardDeck.GetCardDeck().Count % players.Length == 0)
            {
                this.players = new List<Player> { };
                this.players.AddRange(players);
                this.cardDeck = cardDeck;
                table = new List<Card>();
                Step = step;
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
            int player = 0;
            int maxRank = table[player].GetRank();
            for (int i = 1; i < table.Count; i++)
            {
                if (maxRank < table[i].GetRank())
                {
                    maxRank = table[i].GetRank();
                    player = i;
                }
                else if (maxRank == table[i].GetRank())
                {
                    ;
                }
            }
            for (int i = 0; i < table.Count; i++)
            {
                players[player].AddCard(table[i]);
            }
            table.Clear();
        }

        public void Win()
        {
            string playerWin = players[0].Name;
            int countCard = players[0].CountCurrentCard();
            for (int i = 1; i < players.Count; i++)
            {
                if (players[i].CountCurrentCard() > countCard)
                {
                    countCard = players[i].CountCurrentCard();
                    playerWin = players[i].Name;
                }
                else if (players[i].CountCurrentCard() == countCard)
                {
                    ;
                }
            }
            Console.WriteLine($"{playerWin} WIN!!!");
        }
    }
}
