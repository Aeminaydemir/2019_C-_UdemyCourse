using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inherintance
{
    class Program
    {
        public static string City { get; private set; }

        static void Main(string[] args)
        {
            //person[] person = new person[2] {new Customer(),new Student() };
            person[] person = new person[3] { new Customer{FirstName="Burak"}, new Student {FirstName="Bircan"},new person {FirstName="sevde" }  };
            foreach(var persons in person) { Console.WriteLine(persons.FirstName); }
            Console.ReadLine();
        }

        class person { public int Id { get; set; } //kalıtım alıncacak sınıf interface'den önce yazılır.
            public string FirstName { get; set; }
            public string LastName { get; set; }
          }
        class Customer : person { public string City { get; set; }} //Bir nesneye birden fazla kalıtım alamazsın.
        class Student : person { public string  Department{ get; set; }}//ancak birden fazla implementasyon yapabilirsin.(interface)
    }
}
