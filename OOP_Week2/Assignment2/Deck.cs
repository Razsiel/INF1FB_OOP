using System;
using System.Collections.Generic;

namespace Assignment2
{
    public class Deck
    {
        const int MAXVALUEDECK = 14; //ACE is 14
        int players;
        public List<Card> Cards = new List<Card>();

        public Deck(int players) 
        {
            this.players = players;
            for (int i = 0; i < players; i++)
            {
                InitCards();
            }
        }

        public void InitCards()
        {
            foreach (CardSuit suit in Enum.GetValues(typeof(CardSuit)))
            {
                for (int v = 2; v <= MAXVALUEDECK; v++)
                {
                    this.Cards.Add(new Card(suit, v));
                }
            }
        }

        public void Print() 
        {
            foreach (Card card in this.Cards)
            {
                Console.WriteLine(card.ToString());
            }
        }
    }
}
