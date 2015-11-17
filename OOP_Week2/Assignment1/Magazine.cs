using System;
using System.Collections.Generic;
using System.Globalization;

namespace Assignment1
{
    public class Magazine : Book
    {
        private DateTime publishDate;

        public Magazine(string title, decimal price, DateTime publishDate) : base(title, price)
        {
            this.PublishDate = publishDate;
        }

        public DateTime PublishDate
        {
            get { return publishDate; }
            protected set { this.publishDate = value; }
        }

        public override void Print()
        {
            Console.WriteLine("\"{0}\", {1:c}, {2}", this.Title, this.Price, this.PublishDate.ToShortDateString());
        }
    }
}
