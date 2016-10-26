using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KURSkonsola
{
    public class Person
    {

        public int Age { get; set; }

    }

    class Program
    {
        static void Main(string[] args)
        {
            var ktos = new Person();

            ktos.Age.set();
            //int pierwszaZmienna, druga;
            //pierwszaZmienna = 3;
            //druga = 7;
            //if(pierwszaZmienna < druga)
            //{
            //    Console.Write("cos tam");
            //}

            //Console.Write(pierwszaZmienna);

            //Console.ReadKey();
        }
    }
}
