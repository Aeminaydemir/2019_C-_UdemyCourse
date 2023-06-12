using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReferenceAndValueType
{
    class Program//sınıflar,interfaceler,string,arrayler,abstract tip vs.referans tiptir.
    {
        static void Main(string[] args)
        {//Buradaki işlemler sırayla atanıyor.Yani bir satır öncesinde
         //başka değişkene atanmış bir değişken ondan sonraki satır veya
         //";" sonrasında değiştirilse bile değişmiyor. Örne:
            int number1 = 10;   int number2 = 21;
            number2 = number1;   number1 = 123;
            Console.WriteLine(number2);
            //Referansta ise olay daha çok c++ taki pointer ve
            //Dinamik hafıza(heap)olaylarına benziyor.New nesneyi değeri tutuyor .
            //Değişkende onun bellekteki adresini "=" operatörünü kullanmadan önce
            //c++ taki gibi değeri bellekten silmelimiyim diye düşünmeye gerek olmuyor.
            //Çünkü c# bunu senin için yapıyor.Örnek:
            string[] cities1 = new string[] { "Ankara", "Adana" };
            string[] cities2 = new string[] { "Bursa", "Bolu" };
            cities2 = cities1;
            cities1[0] = "İstanbul";
            Console.WriteLine(cities2[0]);
            Console.ReadLine();
        }
    }
}
