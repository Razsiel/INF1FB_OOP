using System;

namespace Assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            Team t = new Team();
            t.AddProgrammer(new Programmer("Geoffrey", Specialty.Csharp));
            t.AddProgrammer(new Programmer("Sjaak", Specialty.HTML));
            t.AddProgrammer(new Programmer("Lance", Specialty.Java));
            t.AddProgrammer(new Programmer("Jake", Specialty.PHP));
            t.PrintAllMembers();
            Console.ReadKey();
        }
    }
}
