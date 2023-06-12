using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Iworker[] workers = new Iworker[3] { new Manager(), new Worker() , new Robot() };
            foreach(var worker in workers) { worker.Work(); }//interfaceler tek başlarına anlam ifade etmezler. 
            Workerights[] Ihuman = new Workerights[2] { new Manager(), new Worker()}; 
        }
        interface Workerights
        {
            void eat();
            void GetSalary();
        }
        interface Iworker
        {
            void Work();
        }
        class Manager : Workerights,Iworker
        {
            public void eat() /// interface'i atadığın yerde özellikleri yazman gerekir.Buda daha fazla özelleştirme sağlar.
            {
                throw new NotImplementedException();
            }

            public void GetSalary()
            {
                throw new NotImplementedException();
            }

            public void Work()
            {
                throw new NotImplementedException();
            }
        }
        class Worker : Workerights,Iworker
        {
            public void eat()
            {
                throw new NotImplementedException();
            }

            public void GetSalary()
            {
                throw new NotImplementedException();
            }

            public void Work()
            {
                throw new NotImplementedException();
            }
        }
        class Robot : Iworker
        {
            public void Work()
            {
                throw new NotImplementedException();
            }
        }
    }
}
