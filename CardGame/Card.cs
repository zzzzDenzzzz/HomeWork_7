using System;

namespace CardGame
{
    internal class Card
    {
        byte suit;
        bool color;
        string[] rank = {"6", "7", "8", "9", "10", "Jack", "Queen", "King", "Ace"};

        public Card(byte suit, bool color)
        {
            this.suit = suit;
            this.color = color;
        }

        public void Show()
        {
            if (color)
            {
                Console.ForegroundColor = ConsoleColor.Red;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Black;
            }
            Console.BackgroundColor = ConsoleColor.White;
            Console.Write($"[{(char)suit}{rank}]");
            Console.ResetColor();
        }
    }
}
