using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecapDemo2
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customer = new CustomerManager();
            customer.Logger = new DatabaseLogger();
            customer.Add();
            Console.ReadLine();
        }
    }
    interface ILogger
    { void Log(); }
    class CustomerManager
    {
        public ILogger Logger { get; set; }//Ilogger türünde geri dönüş yapan bir property nesnesi 
        //(sanki sınıfmış gibi kullanılıyor.)Çünkü normalde bu işlem constructorla yapılıyormuş.Ve buna property injection deniyormuş.
        public void Add()
        {
            Logger.Log();
         Console.WriteLine("Customer Added.");

        }
    }
class DatabaseLogger:ILogger//çıplak klastan kork--> bir klasın base'i olmalı.
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
}
