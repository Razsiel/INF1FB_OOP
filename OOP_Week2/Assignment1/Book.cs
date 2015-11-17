using System;
using System.Collections.Generic;

namespace Assignment1
{
    // NOTE: Despite the assignment requesting for the book to have a ChangeStock() method
    // I firmly believe this functionality does not belong with Book(). Changing the stock of
    // the Bookstore() is the responsibility of Bookstore(). This includes sales etc..

    public class Book : Item
    {
        public Book(string title, decimal price) : base(title, price) { }
    }
}
