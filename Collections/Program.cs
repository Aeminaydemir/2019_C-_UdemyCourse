using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            //ArrayList();
            //List();
            Dictionary<string, string> dictionary = new Dictionary<string, string>();
            dictionary.Add("book", "kitap");
            dictionary.Add("computer", "bilgisayar");
            Console.WriteLine(dictionary["computer"]);
            foreach (var item in dictionary)
            {
                Console.WriteLine(item.Key);//anahtar sözcüğü yazdırır.
               Console.WriteLine(item.Value);//değeri yazdırır.
                Console.WriteLine(item);//anahtar sözcüğü değerle karşılıklı yazdırır. 
            }
            Console.ReadLine();


        }

        private static void List()
        {
            //#2  List
            List<string> cities2 = new List<string>();//Tip güvenlikli bir koleksiyon.Array bazlıdır.
            cities2.Add("Ankara");
            cities2.Add("İstanbul");
            var count = cities2.Count;//Count metodu koleksiyonun eleman sayısını sayar.
            cities2.AddRange(new string[2] { "Amsterdam", "Newyork" }); //Yeni liste ekleme.
            Console.WriteLine(cities2.Contains("Amsterdam"));//Listede olup olmadığına bakar.Bunu kullanırken referansa dikkat et! 
            foreach (var cities in cities2)                 //Aradığın şeyi kayıtlı bellek alanlarına bakarak buluyor sen yeni bellek oluşturursan bulamaz. 
                Console.WriteLine(cities);
            cities2.Clear();//List'i siler.
            cities2.IndexOf("Ankara");//Index0f->listede kaçıncı sırada olduğunu söyler.\LastIndex0f'ta sondan başlar.
            cities2.Insert(0, "Yozgat");//Listenin istediğin yerine yeni eleman ekler.                 
            cities2.Remove("Amsterdam");//İlk bulduğu istenen değeri siler.
            var count2 = cities2.Count;
            Console.WriteLine(count);
            Console.WriteLine(count2);
        }

        private static void ArrayList()
        {
            string[] cities = new string[2] { "Ankara", "İstanbul" };//Arraylerde yeni eleman eklemenin vb. sorunların
           //Dinamik zorluklarından kaçınmak için genelde arrayler yerine  koleksiyonlar kullanılır.
           //#1 ArrayList
            ArrayList Cities = new ArrayList();//typr safe durumu yoksa kullamılır
            Cities.Add("Ankara");//type safe te sadece belli tipi kullanırsın.
            Cities.Add("Adana");
            Console.WriteLine(Cities[1]);
        }
    }
}
