using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            //ExceptionIntro();
            try
            {
                Find();
            }
            catch (RecordNotFoundException exception)
            {

                Console.WriteLine(exception.Message);
            }
            Console.ReadLine();
        }

        private static void Find()
        {//Action Delegation->HandleException(()=>{işlem }); burada delegate kullnımı var.(sonranın konusu) Genelde merkezi bir class'a konulur.
            List<string> students = new List<string> { "engin", "Derin", "Salih" };
            if (!students.Contains("Ahmet"))
            {
                throw new RecordNotFoundException("Record Not Found");
            }
            else
            {
                Console.WriteLine("Record Found!");
            }
        }

        private static void ExceptionIntro()
        {
            try //hata var mı diye denenmesini istediğin kodu buraya yazıyorsun.
            {
                string[] students = new string[3]
            {"Engin","Derin","Salif"};
                students[3] = "Ahmet";
            }//catch'in içerisine hatanın türünü yazarak hataya özel tepkilerde oluşturabilirsin.Ancak catchlerden biri hatayı yakaladığı zaman diğer catchlere girmez.
            catch (Exception exception)//Eğer hata bulursa yukardaki kodda bu satıra geçilip buradaki işlem yapılıyor.
            {//Try bloğunda hata olduğunda exception nesnesine aktarılır. 
                Console.WriteLine(exception.Message);//Exception.message metodu'nu (genelde) kullanıcıya göstermemelisin
                                                     //Console.WriteLine("EXCEPTIONN!!!");   //Genelde veritabanına veya başka biryere loglamalısın.   
                Console.WriteLine(exception.InnerException);//varsa hata hakkında daha detaylı bilgi verir
            }
        }
    }
}
