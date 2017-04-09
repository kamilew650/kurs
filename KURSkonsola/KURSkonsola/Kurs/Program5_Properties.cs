using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KURSkonsola.Kurs
{
    class Person
    {
        public DateTime Birthdate { get; set; }
        public int Age
        {
            get
            {
                var timeSpan = DateTime.Today - Birthdate;
                var years =  timeSpan.Days/365;
                return years;
            }
        }
    }

    class Program5_Properties
    {
        //static void Main(string[] args)
        //{
        //    var person = new Person();
        //    person.Birthdate = new DateTime(1982, 1, 1);
        //    Console.WriteLine(person.Age);
        //}
    }
}
