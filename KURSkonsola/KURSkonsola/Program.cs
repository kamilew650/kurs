using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KURSkonsola
{
    public abstract class Person
    {

        public abstract int Age { get; set;}
        protected int Costam;

        public Person(int age, int costam)
        {
            this.Age = age;
            this.Costam = costam;
        }

        public abstract void cos();

    }


    public class Student : Person
    {

        public bool jedzenie;

        public override int Age
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public Student(int age, int costam) : base(age,costam)
        {
            this.Age = age;
            this.Costam = costam;
            this.jedzenie = true;
        }

        public override void cos()
        {
            Console.Write("no druga");
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            KursACs no = new KursACs();

            no.wczytaj();
            no.wypisz();

            //Person ktos = new Student(1, 3);

            //ktos.cos();
            //Console.Write(ktos.g);

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
