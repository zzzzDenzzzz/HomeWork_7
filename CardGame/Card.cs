using System;

namespace CardGame
{
    internal class Card
    {
        byte suit;
        bool color;
        string rank;

        public Card(byte suit, bool color, string rank)
        {
            this.suit = suit;
            this.color = color;
            this.rank = rank;
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
