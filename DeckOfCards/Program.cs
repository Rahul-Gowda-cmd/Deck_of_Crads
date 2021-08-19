using System;

namespace DeckOfCards
{
    class Program
    {
        static void Main(string[] args)
        {
            //Display Message
            Console.WriteLine("Welcome to Deck Of Cards!");

            //Call Class
            Cards cards = new Cards();
            cards.CardsCreator();
        }
    }
}
