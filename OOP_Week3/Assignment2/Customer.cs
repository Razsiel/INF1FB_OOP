using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    public class Customer
    {
        private int id;

        public Customer(int id, string name, string surname, string email)
        {
            this.ID = id;
            this.Name = name;
            this.Surname = surname;
            this.Email = email;
        }

        public string Name { get; set; }
        public string Surname { get; set; }
        public int ID { get { return this.id; } protected set { this.id = value; } }
        public string Email { get; set; }

        public override string ToString()
        {
            return string.Format("{0}. {1} {2} - {3}", this.ID, this.Name, this.Surname, this.Email );
        }
    }
}
