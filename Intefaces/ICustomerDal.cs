using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intefaces
{
    interface ICustomerDal
    {
        void Add();
        void Update();
        void Delete();
    }
    class SqlServerCustomerDal : ICustomerDal
    {
        public void Add()
        {
            Console.WriteLine("SQL Added.");
        }
        //Normalde ayrı dosyalara yazılır SQL vs ancak örnek olduğu için böyle yazdık.Alt alta görelim diye
        public void Delete()
        {
            Console.WriteLine("SQL Deleted.");
        }

        public void Update()
        {
            Console.WriteLine("SQL Updated.");
        }
    }
        class OracleServerCustomerDal : ICustomerDal
        {
            public void Add()
            {
                Console.WriteLine("Oracle Added.");
            }

            public void Delete()
            {
                Console.WriteLine("Oracle Deleted.");
            }

            public void Update()
            {
                Console.WriteLine("Oracle Updated.");
            }
        }
        class CustomerManager
        {
            public void Add(ICustomerDal customerDal)///Burada interface kullanarak hem oracle hemde sql server'ı destekler hale getirmiş olduk
            { customerDal.Add(); }
        }
    
}
