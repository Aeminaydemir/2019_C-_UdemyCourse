using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            SqlServer sqlServer = new SqlServer();
            sqlServer.Add();
            MySql mySql = new MySql();
            mySql.Add();
            Console.ReadLine();
        }
    }
    class Database
    { public virtual void  Add()//Ortak işlevlerin kullanılacağı durumda virtual kullanımı birşey değiştirmez.
        { Console.WriteLine("Added by default."); } }
    class SqlServer : Database
    {
        public override void Add() // Ortak özellikler'de farklılık gösteren durumlarda virtual kullanılır.(buna ezmek deniyor)
        {
            Console.WriteLine("Added by SQL code .");//interfacelerde böyle birşey yapamazsın 
            //base.Add();
        }
    }
    class MySql : Database { }
}
