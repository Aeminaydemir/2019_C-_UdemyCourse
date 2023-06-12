using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Console = System.Console;

namespace Methods
{
    class Program
    {
        public static void Topla(ref int a,ref int  b)
        {
            a = a + b;
            b = a - b;
            Console.WriteLine("Fonksiyonun içi Topla:\na={0}\nb={1}", a, b);
        }
        static void Add()
        {
            Console.WriteLine("Added!");
        }
        static void Add2(int number1,int  number2)
        {
            Console.WriteLine("number1+number2 {0}",number1+number2);

        }
        static int Add3(int number1, int number2)
        {
            return number1 + number2 ;
        }
        static int Add3(int number1, int number2,int number3) //methodların aşırı yüklenmesi durumu aynı methodu farklı yazmak.
        {
            Console.WriteLine("method overloading");
            return number1 + number2+number3;
        }
        static int Adddefault(int number1=14, int number2=12) //Defaut verilirken önce sağdakilere verilmeli.
        {
            return number1 + number2;
        }
        static int Addref(ref int number1 , ref int number2) //Ref keyword (anahtar kelimesi) kullanarak direkt değişkenler üzerinde çalışırız pointerlar gibi
        {
            int i;
            i = number1;
            number1 = number2;
            number2 = i;
            return number1 + number2;
        }
        // out anahtar kelimesi Ref gibi referans tipidir. Ancak methodun içinde gönderilen değişkenin en az birkez değer verilmesi(set edilmesi) gerekmektedir.
        static int Add3(params int[] numbers) //params dizi notasyonuyla yazarak istediğimiz kadar parametreyi gönderebiliyoruz sırasının belirli olması gerekmiyor.Ancak params parametre olarak son parametre olmak sonunda.
        {
            return numbers.Sum();
        }

        static void Main(string[] args)
        { //int number1 = 100;
          //    int number2=45;
          //    Console.WriteLine("number1 {0}", number1);
          //    Console.WriteLine("number2 {0}", number2);
          //    Add();
          //    int result3=Adddefault();
          //    Console.WriteLine("Adddefault: {0}",result3 );
          //    int Result1= Add3(156, 543);
          //    Console.WriteLine("Add3: {0}", Result1);
          //    Add2 (42,134);
          //    int result2=Addref(ref number1, ref number2); //  değeri hemen vereceksen ref kullanmak mantıklı eğer değer sonradan girilecekse (ancak out method içerisinde bir varsayılan değere sahip olmalı) out kullanmalısın ikiside zaten pointer mantığında çalışıyor.
          //    Console.WriteLine("number1 {0}", number1);
          //    Console.WriteLine("number2 {0}", number2);
          //    Console.WriteLine("Addref: {0}", result2);
          //    Console.ReadLine();
            int a = 12,b=5;
            Topla(ref a,ref b);
            Console.WriteLine("Main sınıfının içi Topla:\na={0}\nb={1}",a,b);
            Console.ReadKey();
         }


    }
}
