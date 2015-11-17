using System;

namespace Assignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            Deck game = new Deck(2);
            game.Print();

            Console.ReadKey();
        }
    }
}
