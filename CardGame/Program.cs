namespace CardGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CardDeck cardDeck = new CardDeck();
            cardDeck.Show();
            cardDeck.Shuffle();
            cardDeck.Show();
        }
    }
}
