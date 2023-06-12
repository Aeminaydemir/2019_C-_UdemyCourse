using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intefaces
{
    class Program
    {
        static void Main(string[] args)
        {
            ///Interfaceler new'lenemez.
            //InterfacesIntro();
            // Demo();
            ICustomerDal[] customerDals = new ICustomerDal[2]
            {
                new SqlServerCustomerDal(),new  OracleServerCustomerDal()
            };
            foreach (var customerdal in customerDals) { customerdal.Add(); }
            Console.ReadLine();
        }

        private static void Demo()
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(new SqlServerCustomerDal()); //interfaceler gerçek hayatta katmanlar arası geçişte kullanıyoruz.
        }

        private static void InterfacesIntro()
        {
            PersonManager personManager = new PersonManager();
            customer customer = new customer { ID = 123, FirstName = "alim", LastName = "abasıyanık", Adress = "köymerkezi" };
            Student student = new Student { ID = 156, FirstName = "zalimo", LastName = "çabasıuyanık", Department = "electric-electronic engineering " };
            // personManager.Add(new customer { ID = 123, FirstName = "alim", LastName = "abasıyanık", Adress = "köymerkezi" });//diğer yol
            personManager.Add(student);
            personManager.Add(customer);
            
        }

        interface Iperson ///Amacı bir temel nesne oluşturup diğerlerini ondan uygulumaktır.Ve bir soyut nesnedir ve tek başına bir anlamları yoktur.
        {
            int ID { get; set; }
            string FirstName{ get; set; }
            string LastName { get; set; }
        }
        class customer : Iperson
        {
            public int ID { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string Adress { get; set; }
        }
        class Student : Iperson
        {
            public int ID { get ; set ; }
            public string FirstName { get ;  set; }
            public string LastName { get ; set; }
            public string Department { get; set; }
        }
        class PersonManager
        {
            public void Add(Iperson ıperson) ///Parametre olarak interface verdiğinde aynı inteface'e bağlı bütün nesnelere paramete olarak ulaşabilirsin.
            {
                Console.WriteLine(ıperson.FirstName);
            }

        }


    }
}
