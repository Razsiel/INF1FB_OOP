using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    public class Reservation
    {
        private int id;
        private Book book;
        private Customer customer;

        public Reservation(int id, Customer customer, Book book)
        {
            this.ID = id;
            this.Customer = customer;
            this.Book = book;
            this.ReservationDate = DateTime.Now;
        }

        public Book Book { get { return this.book; } protected set { this.book = value; } }
        public Customer Customer { get { return this.customer; } protected set { this.customer = value; } }
        public int ID { get { return this.id; } protected set { this.id = value; } }
        public DateTime ReservationDate { get; set; }

        public override string ToString()
        {
            return string.Format("Reservation ID#: {0}. \n{1} \n{2} \n{3}\n", this.ID, this.Customer.ToString(), this.Book.ToString(), this.ReservationDate.ToShortDateString());
        }
    }
}
