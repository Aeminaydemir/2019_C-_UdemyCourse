using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifiers
{
    class Program
    {
        static void Main(string[] args)
        {
        }
     }
    class Customer
    {
        int id;//private olarak atanır.
               //Private sadece ve sadece tanımlandığı blokta  kullanılır.
        protected int SN;//protected'ta private gibidir.
                         //Tek farkı kalıtım alınan yerde kullanılabilr.
        public void save() { int Ad; }
        public void Delete() { }//Ad değişkenini burada kullanamazsın.

    }
    class Student : Customer
    {
        public void Add() { SN = 9; }
    }
    class Course //Bir classın varsayılanı (default'u) internal'dır.
    {
        //Üst seviyeli bir sınıf private olamaz.protectedda olamaz!
        //Sadece Public ve İnternal.
        //Projeden projeye sınıf kullanmak içinde public ,
        //Aynı proje (assembly) içindekiler içinde internal.
        public string Name { get; set; }
        private class NestedClass { }//İç içe classlarda ancak private ve protected olur.
    }
public class Courser { };

} 
