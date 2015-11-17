using System;
using System.Collections.Generic;
using System.Globalization;

namespace Assignment1
{
    public abstract class Item
    {
        private string title;
        private decimal price = 0.00M;

        public Item(string title, decimal price)
        {
            this.Title = title;
            this.Price = price;
        }

        public string Title
        {
            get { return this.title; }
            protected set { this.title = value; }
        }

        public decimal Price
        {
            get { return this.price; }
            set
            {
                if (value < 0)
                    value = 0;
                this.price = value;
            }
        }
        /* Price overload
        public float Price
        {
            get { return (float)decimal.Round(this.price, 2, MidpointRounding.AwayFromZero); }
        }*/

        public virtual void Print()
        {
            Console.WriteLine("\"{0}\", {1:c}", this.Title, this.Price);
        }
    }
}
