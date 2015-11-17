using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtraAssignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            YahtzeeGame game = new YahtzeeGame();

            int attempts = 0;
            do
            {
                game.Throw();
                attempts++;
            } while (!game.Yahtzee()); //TODO: while game.result == Nothing...

            Console.WriteLine("Attempts needed for Yahtzee: {0}", attempts);
            Console.ReadKey();
        }
    }
}
