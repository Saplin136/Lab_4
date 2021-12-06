using System;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person("Vladimir", "Lenin");
            p1.Bio();
            Console.WriteLine();

            Student s1 = new Student("Anton", "Saplin", 21, "NAU", 1, "EC 136стн");
            s1.Bio();
            s1.StudInfo();
            Console.WriteLine();

            Musician m1 = new Musician("Joseph", "Stalin");
            m1.Bio();
            m1.EXP();
            Console.WriteLine();

            Guitarist g1 = new Guitarist("Nikita", "Khrushchev", "Acoustic Guitar");
            g1.Bio();
            g1.EXP();
        }
    }
}
