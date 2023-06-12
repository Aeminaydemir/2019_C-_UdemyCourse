using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customer = new CustomerManager(23);
            EmployeeManager employee = new EmployeeManager(new DatabaseLogger());
            employee.Add();
            PersonManager person = new PersonManager("Product");
            person.Add();
            Console.ReadLine();
        }
    }
    class CustomerManager
    {
        private int _count;//private bir alan "_"  ile başlatılır.
        public CustomerManager() //Sınıfın kurucu metodu.
        {
            Console.WriteLine("Constructer Activated.");
        }
        public CustomerManager(int a)
        {
            Console.WriteLine("Constructer Activated with {0}th keyword.",a);//COnstructor'un aşırı yükleme(overload) yapılması.
        }
      }
      interface ILogger
        { void Log(); }
        class EmployeeManager
        {
            private ILogger _logger;
            public EmployeeManager(ILogger logger)//constructor injection.
            {
                _logger = logger;
            }
            public void Add()
            {
                _logger.Log();
                Console.WriteLine("Employee Added.");

            }
        }
        class DatabaseLogger : ILogger
        {
            public void Log()
            { Console.WriteLine("Logged to Database!"); }

        }

        class FileLogger : ILogger
        {
            public void Log()
            {
                Console.WriteLine("Logged to File!");
            }
        }
    class BaseClass
    {
        private string _entity;
        public BaseClass(string entity)
        {
            _entity = entity;
        }
        public void Message()
        {
            Console.WriteLine("{0} message",_entity);
        }

    }
    class PersonManager:BaseClass
    {
        public PersonManager(string entity):base(entity)//Temel sınıfın yapıcı bloğuna parametre yollamak. 
        {

        }
        public void Add()
        { Console.WriteLine("Added!"); Message(); }
    }
    static class Teacher // static nesne**static nesne newlenmez. 
    {
        
        public static int Number { get; set; } //içerdeki metodlarda statik olmalı.
        //static nesne newlenmeden tanımlanır.
        //Ortak nesnelerdir.
    }
}
 