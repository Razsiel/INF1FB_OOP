using System;
using System.Collections.Generic;

namespace Assignment1
{
    public class Bookstore
    {
        public List<Item> Stock = new List<Item>();

        public void AddToStock(Item item)
        {
            this.Stock.Add(item);
        }

        public void AddToStock(Item item, int amount)
        {
            for (int i = 0; i < amount; i++)
            {
                this.Stock.Add(item);
            }
        }

        public void RemoveFromStock(Item item)
        {
            this.Stock.Remove(item);
        }

        public void RemoveFromStock(Item item, int amount)
        {
            for (int i = 0; i < amount; i++)
            {
                this.Stock.Remove(item);
            }
        }

        public void RemoveAllFromStock(Item item)
        {
            this.Stock.RemoveAll(i => i == item);
        }

        public void PrintStock()
        {
            Console.WriteLine(" #. Title, Price(, date of publish)");
            decimal collectivePrice = 0.00M;
            int current = 1;
            foreach (Item item in this.Stock)
            {
                Console.Write(string.Format("{0,2:##}. ", current));
                item.Print();
                collectivePrice += item.Price;
                current++;
            }
            Console.WriteLine();
            Console.WriteLine("All items in stock are worth: {0:c}", collectivePrice);
        }
    }
}
