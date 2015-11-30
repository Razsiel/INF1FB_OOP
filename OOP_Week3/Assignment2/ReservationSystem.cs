using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    public class ReservationSystem
    {
        public ReservationSystem(string name) 
        {
            this.Name = name;

            // Should do this in the properties... (time constraint train trip...)
            this.Customers = new List<Customer>();
            this.Books = new List<Book>();
            this.Reservations = new List<Reservation>();
            // end

            this.GetBooks();
            this.GetCustomers();
            this.GetReservations();
            
        }

        public string Name { get; set; }
        public List<Customer> Customers { get; set; }
        public List<Reservation> Reservations { get; set; }
        public List<Book> Books { get; set; }

        private void GetBooks() 
        {
            this.Books.Add(new Book(0, "The answer to life, the universe and everything", "Zebrox Fortytwo"));
            this.Books.Add(new Book(1, "Anagrams for beginners", "Ymos Aunos"));
        }

        private void GetCustomers() 
        {
            this.Customers.Add(new Customer(0, "Jan", "Jansen", "jan@jansen.nl"));
            this.Customers.Add(new Customer(1, "Pieter", "Post", "pieterpost@tnt.com"));
        }

        private void GetReservations() 
        {
            this.Reservations.Add(new Reservation(0, this.Customers[0], this.Books[0]));
            this.Reservations.Add(new Reservation(1, this.Customers[0], this.Books[1]));
            this.Reservations.Add(new Reservation(2, this.Customers[1], this.Books[1]));
        }
    }
}
