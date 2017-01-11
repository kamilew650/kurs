using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KURSkonsola
{
    public class Person
    {
        public string Name;

        public void Introduce(string to)
        {
            Console.WriteLine("Hi {0}, I am {1}", to, Name);
        }

        public static Person Parse(string str)
        {
            var person = new Person();
            person.Name = str;
            return person;
        }
    }

    //class Program1
    //{
    //    static void Main(string[] args)
    //    {
    //        var p = Person.Parse("John");
    //        p.Introduce("Mosh");
    //    }
    //}
}
