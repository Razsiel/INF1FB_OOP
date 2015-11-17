using System;

namespace Assignment1
{
    public class Programmer
    {
        private string Name;
        private Specialty Specialty;

        public Programmer(string name, Specialty specialty)
        {
            Name = name;
            Specialty = specialty;
        }

        public void Print()
        {
            Console.WriteLine("{0}: \tName: {1} \tSpecialty: {2}", this.GetType().Name, this.Name, this.Specialty.ToString());
        }
    }
}
