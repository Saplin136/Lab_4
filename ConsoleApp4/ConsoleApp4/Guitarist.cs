using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp4
{
    class Guitarist : Musician
    {
        string Tog;
        public Guitarist(string Fname, string Lname, string tog) : base(Fname, Lname)
        {
            Tog = tog;
        }
        public override void EXP()
        {
            Console.WriteLine("I have been a musician for " + Exp + " years. I play " + Tog + ".");
        }
    }
}
