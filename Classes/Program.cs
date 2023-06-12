using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.add();
            Console.ReadLine();
        }
    }
    //class CustomerManager
    //{
    //    public void add() { Console.WriteLine("Customer added!"); }


    //}
}
