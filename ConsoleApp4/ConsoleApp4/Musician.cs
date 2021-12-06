using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp4
{
    class Musician : Person
    {
        public int Exp;
        public Musician(string Fname, string Lname) : base(Fname, Lname)
        {
            Random rnd = new Random();
            Exp = (Age / 2) - rnd.Next(0, ((Age / 2) - 1));
        }

        public virtual void EXP()
        {
            Console.WriteLine("I have been a musician for " + Exp + " years.");
        }
    }
}
