using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp4
{
    class Student : Person
    {
        private string Univer;
        private int Cours;
        private string Group;
        public Student(string Fname, string Lname, int age, string univer, int cours, string group) :base(Fname, Lname)
        {
            Random rnd = new Random();
            Age = age;
            Univer = univer;
            Cours = cours;
            Group = group;
        }

        public void StudInfo()
        {
            Console.WriteLine("I`m studying in " + Univer + ". Cours: " + Cours + ", group: " + Group + ".");
        }
    }
}
