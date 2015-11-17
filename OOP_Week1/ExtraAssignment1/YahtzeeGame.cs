using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtraAssignment1
{
    public class YahtzeeGame
    {
        int[] dice;
        Random rnd;

        public YahtzeeGame()
        {
            dice = new int[5];
            rnd = new Random();
        }

        public void Throw()
        {
            for (int i = 0; i < this.dice.Length; i++)
            {
                dice[i] = this.rnd.Next(1, 7);
            }
            Console.WriteLine("Result: {0}", string.Join(", ", this.dice));
        }

        public bool Yahtzee() 
        {
            if (Array.TrueForAll(this.dice, current => { return current == dice[0]; }))
                return true;
            return false;
        }

        public bool ThreeOfAKind()
        {
            return false;
        }

        //TODO: Return result as a Type: Nothing, ThreeOfAKind, FourOfAKind, Yahtzee etc..
    }
}
