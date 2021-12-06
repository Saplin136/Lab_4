using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp4
{
    class Person
    {
        private string FirstName;
        private string LastName;
        public int Age;

        public Person(string Fname, string Lname)
        {
            Random rnd = new Random();
            Age = rnd.Next(14, 100);
            FirstName = Fname;
            LastName = Lname;
        }

        public void Bio()
        {
            Console.WriteLine("Hi! My name is " + FirstName + " " + LastName + ". I`m " + Age + " years old.");
        }
    }
}
