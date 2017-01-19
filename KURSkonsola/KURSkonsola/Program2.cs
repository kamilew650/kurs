using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace KURSkonsola
{
    public class Customer
    {
        public int Id;
        public string Name;
        public List<Order> Orders;

        public Customer()
        {
            Orders = new List<Order>();
        }

        public Customer(int id)
            : this()
        {
            this.Id = id;
        }

        public Customer(int id, string name)
            : this(id)
        {
            this.Name = name;
        }

    }

    public class Order
    {

    }


    //class Program2
    //{
    //    static void Main(string[] args)
    //    {
    //        var customer = new Customer(1,"john");
    //        Console.WriteLine(customer.Id);
    //        Console.WriteLine(customer.Name);
    //    }
    //}
}
