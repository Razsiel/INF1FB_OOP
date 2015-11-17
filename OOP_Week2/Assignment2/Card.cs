using System;

namespace Assignment2
{
    public enum CardSuit
    {
        Heart,
        Diamond,
        Spade,
        Clover
    }

    public class Card
    {
        private CardSuit suit;
        private int value;

        public Card(CardSuit suit, int value)
        {
            this.Suit = suit;
            this.Value = value;
        }

        public CardSuit Suit
        {
            get { return this.suit; }
            protected set { this.suit = value; }
        }

        public int Value
        {
            get { return this.value; }
            protected set 
            {
                if (value < 2 || value == 1)
                    value = 14;
                this.value = value; 
            }
        }

        public override string ToString()
        {
            int v = this.Value;
            string valueString = (v == 11) ? "Jack" : (v == 12) ? "Queen" : (v == 13) ? "King" : (v == 14) ? "Ace" : v.ToString();
            return string.Format("{0} {1}", this.Suit.ToString(), valueString);
        }
    }
}
