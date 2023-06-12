using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            Database database = new OracleServer();//abstract sınıflar birer inheritancetır ancak interfaceler gibi newlenemez.
            database.Add();
            database.Delete();
            Console.ReadLine();
        }
    }
    abstract class Database
    { public void Add() { Console.WriteLine("Add by default"); }
        public abstract void Delete();

    }
    class SqlServer : Database
    {
        public override void Delete()
        {
            Console.WriteLine("DEleted by Sql");
        }
    }
    class OracleServer : Database
    {
        public override void Delete()
        {
            Console.WriteLine("DEleted by Oracle");
        }
    }
}
