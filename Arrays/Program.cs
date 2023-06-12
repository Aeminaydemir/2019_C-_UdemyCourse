using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] students = new string[4];//dizi tanımlama.
            string[] stundents2 = new []{ "ali", "veli", "fatma" };//başlangıç değeri ile dizi tanımlama .
            string[] stundents3 =  { "ali", "veli", "fatma" };
            int[,] polydimension =new int[2,3] ;//çokboyutlu dizi yani matris örneği 2 satır 3 sütun.
            int[,] polydimension2 = new int[2, 3] 
            { // bu şekildede yazılabilir.
                { 2,3,4},
                { 1,5,8}
            };
        }
    }
}
