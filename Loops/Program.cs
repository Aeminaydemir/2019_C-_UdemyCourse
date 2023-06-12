using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    class Program
    {
        

       
        static void Main(string[] args)
        {//klasik for döngüsü.->for(sayaç;şart;döngü sonu işlemi)
         //Forloops();
         //int number = 100;
         //klasik wkile döngüsü->while(şart)
         // whileloops(number);
         // klasik do while döngüsü do {} while(şart)
         // dizi temelli döngü foreach.NOT:foreachin işlem yaptığı diziyi döngü içerisinde deiştiremeyiz.
         //Foreacloop();
            bool result=İsprimenum(10);
            Console.ReadLine();
         }

        private static bool İsprimenum(int number)
        {
            bool result = true;
            for (int i = 2; i <= number / 2; i++)
            {
                if (number % i == 0) { result = false; break; }
            }
            Console.WriteLine(result);
            return result;
        }

        private static void Foreachloop()
        {
            string[] students = { "ali", "veli", "nimet" };
            foreach (var student in students) { Console.WriteLine(student); }
            
        }

        private static int whileloops(int number)
        {
            while (number >= 0) { number--; Console.WriteLine("daha gelmedik mi ?"); }
            return number;
        }

        private static void Forloops()
        {
            for (int i = 1; i <= 100; i++, Console.WriteLine("{0}. dönüş tamamlandı ", i - 1))
            { Console.WriteLine(i * i + 121); }
        }
    }
}
