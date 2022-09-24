using System;

namespace CardGame
{
    internal class Card
    {
        string suit;
        string rank;

        public Card(string suit, string rank)
        {
            this.suit = suit.ToLower();
            this.rank = rank.ToUpper();
        }

        public void Show()
        {
            char? symbol = null;

            if (suit == "diamonds")
            {
                Console.ForegroundColor = ConsoleColor.Red;
                symbol = '\u2666';
            }
            else if (suit == "hearts")
            {
                Console.ForegroundColor = ConsoleColor.Red;
                symbol = '\u2665';
            }
            else if (suit == "clubs")
            {
                Console.ForegroundColor = ConsoleColor.Black;
                symbol = '\u2663';
            }
            else if (suit == "spades")
            {
                Console.ForegroundColor = ConsoleColor.Black;
                symbol = '\u2660';
            }
            else
            {
                throw new Exception();
            }

            Console.BackgroundColor = ConsoleColor.White;
            Console.Write($"[{symbol}{rank}]");
            Console.ResetColor();
        }
    }
}
