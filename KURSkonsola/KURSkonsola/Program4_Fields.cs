using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KURSkonsola
{
    public class Customers
    {
        public int Id;
        public string Name;
        public readonly List<Orders> Orders = new List<Orders>();

        public Customers(int id)
        {
            this.Id = id;
        }

        public Customers(int id, string name)
            : this(id)
        {
            this.Name = name;
        }

        public void Promote()
        {
            //....
        }
    }

    public class Orders
    {

    }

    class Program4_Fields
    {
        public static void Main(string[] args)
        {
            Customers c = new Customers(1);
            c.Orders.Add(new KURSkonsola.Orders());
            c.Orders.Add(new KURSkonsola.Orders());

            c.Promote();

            Console.WriteLine(c.Orders.Count);
        }
    }
}
