using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    public class Book
    {
        private int id;

        public Book(int id, string title, string author)
        {
            this.ID = id;
            this.Title = title;
            this.Author = author;
        }   

        public string Author { get; protected set; }
        public int ID { get { return this.id; } protected set { this.id = value; } }
        public string Title { get; protected set; }

        public override string ToString()
        {
            return string.Format("{0}. {1} - {2}", this.ID, this.Title, this.Author);
        }

    }
}
