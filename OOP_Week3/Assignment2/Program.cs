using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create system
            ReservationSystem system = new ReservationSystem("RS1");

            // Show customers
            Console.WriteLine("Klanten:");
            foreach (Customer customer in system.Customers)
                Console.WriteLine(customer);
            Console.WriteLine();

            // Show available books
            Console.WriteLine("Boeken:");
            foreach (Book book in system.Books)
                Console.WriteLine(book);
            Console.WriteLine();

            // Show reservations
            Console.WriteLine("Reserveringen:");
            foreach (Reservation reservation in system.Reservations)
                Console.WriteLine(reservation);
            Console.ReadKey();
        }
    }
}
