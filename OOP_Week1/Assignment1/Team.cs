using System;
using System.Collections.Generic;

namespace Assignment1
{
    public class Team
    {
        List<Programmer> programmers = new List<Programmer>();

        public void PrintAllMembers()
        {
            foreach (Programmer p in this.programmers)
            {
                p.Print();
            }
        }

        public void AddProgrammer(Programmer p)
        {
            this.programmers.Add(p);
        }
    }
}
