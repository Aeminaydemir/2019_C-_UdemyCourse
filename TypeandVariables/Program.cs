using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeandVariables
{
    class Program
    {
        static void Main(string[] args)
        {
            //value types
            int number1 = 2147483647;
            long number2 = 214748364700000423;
            short number3 = 32767;
            byte number4 = 255;
            bool condition = false;
            char character = 'A';
            double number5 =15324324324432.213;
            decimal number6 = 123342132345424424121431.14214214214214214214214214m; //ondalık için sonuna m konulmalı
            var number7 = 13;
            Console.WriteLine(" var number 7 is {0}",number7);
            number7 = 'A'; // ilk atamadan sonraki atamalar integer olarak kabul edilir.
            Console.WriteLine(" var number 7 is now {0}", number7);
            Console.WriteLine(days.friday);
            Console.WriteLine((int)days.friday);
            Console.WriteLine("int n1 is {0}", number1);
            Console.WriteLine("long n2 is {0}", number2);
            Console.WriteLine("short n3 is {0}", number3);
            Console.WriteLine("byte n4 is {0}", number4);
            Console.WriteLine("condition bool is {0}", condition);
            Console.WriteLine("chararacter char is {0}", character);
            Console.WriteLine("chararacter char is {0}", (int)character);
            Console.WriteLine("number5 double is is {0}", number5);
            Console.WriteLine("number6 decimal is is {0}", number6);

            Console.ReadLine();
        }
    }
    enum days
    {
        monday=12,tuesday=32,wednesday=912,thursday,friday,satuurday,sunday
    }
} 
