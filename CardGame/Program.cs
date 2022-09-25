using System;

namespace CardGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var player_1 = new Player("Pl_1");
            var player_2 = new Player("Pl_2");
            var player_3 = new Player("Pl_3");

            var cardDeck = new CardDeck();

            var game = new Game(cardDeck, player_1, player_2, player_3);

            cardDeck.Shuffle();

            game.DealingCards();

            while (true)
            {
                Console.Clear();

                game.ShowCardsInPlayer();

                game.PutCards();
                game.PlayerTakesCards();

                Console.ReadLine();
            }
        }
    }
}
