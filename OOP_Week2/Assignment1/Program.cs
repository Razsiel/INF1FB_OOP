using System;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;
using System.Text;

namespace Assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Bookstore bookstore = new Bookstore();

            Book book1 = new Book("The answer to everything...", 42.00M);
            Magazine mag1 = new Magazine("WD40 weekly tips!", 8.95M, new DateTime(2012, 10, 7));
            CD cd1 = new CD("Sounds of the universe", 9.99M);
            bookstore.AddToStock(book1, 24);
            bookstore.AddToStock(mag1, 10);
            bookstore.AddToStock(cd1);
            bookstore.PrintStock();

            Console.ReadKey();
        }
    }
}
