using System;

namespace Classes
{
    public class Person1
    {
        public string Name;

        public void Introduce(string to)
        {
            Console.WriteLine("Hi {0}, my name is {1}", to, Name);
        }

        public static Person1 PersonfrmStr(string str)
        {
            var person = new Person1();
            person.Name = str;

            return person;
        }
    }
    class Program1
    {
        static void Main1(string[] args)
        {
            ;
            var p = Person1.PersonfrmStr("John");

            p.Introduce("Tan");

        }
    }
}
