using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STrings
{
    class Program
    {
        static void Main(string[] args)
        {
            Intro();
            string sentence = "My name is A.emin";
            var result = sentence.Length;
            var result1 = sentence.Clone();
            sentence = "My name is Abdulkadir aydemir.";
            bool result2 = sentence.EndsWith("r");
            bool result3 = sentence.StartsWith("a");
            var result4 = sentence.IndexOf("emi");
            var result5 = sentence.LastIndexOf("ame");
            var result6 = sentence.Insert(0, "Papicino");
            var result7 = sentence.Substring(3, 4);
            var result8 = sentence.ToLower();
            var result9 = sentence.ToUpper();
            var result10 = sentence.Remove(2,5);
            var result11 = sentence.Replace(" ","&");
            Console.WriteLine(result11);
            Console.ReadLine();

        }

        private static void Intro()
        {
            string city = "Ankara";
            //Console.WriteLine(city[0]); //string aslında bir dizidir.
            foreach (var item in city) { Console.WriteLine(item); }
            string city2 = "İstanbul";
            Console.WriteLine(city + city2);
            Console.WriteLine(string.Format("{0} {1}", city, city2));
        }
    }
}
