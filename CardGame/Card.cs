using System;

namespace CardGame
{
    internal class Card
    {
        string suit;
        int rank;

        public Card(string suit, int rank)
        {
            this.suit = suit.ToLower();
            this.rank = rank;
        }

        public void Show()
        {
            char? symbol;

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

            string RankInLine(int rank)
            {
                switch (rank)
                {
                    case 6:
                        return " 6";
                    case 7:
                        return " 7";
                    case 8:
                        return " 8";
                    case 9:
                        return " 9";
                    case 10:
                        return "10";
                    case 11:
                        return " J";
                    case 12:
                        return " Q";
                    case 13:
                        return " K";
                    case 14:
                        return " A";
                    default:
                        break;
                }
                return "0";
            }

            Console.BackgroundColor = ConsoleColor.White;
            Console.Write($"[{symbol}{RankInLine(rank)}]");
            Console.ResetColor();
        }

        public int GetRank()
        {
            return rank;
        }
    }
}
