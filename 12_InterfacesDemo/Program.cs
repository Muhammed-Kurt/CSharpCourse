using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_InterfacesDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Çoklu İmplementasyon
            IWorker[] workers =
            {
                new Manager(),
                new Worker(),
                new Robot(),
            };

            foreach (var worker in workers)
            {
                worker.Work();
            }

            Console.WriteLine("------------------------------");

            IEat[] eats =
            {
                new Manager(),
                new Worker(),
            };

            foreach (var eat in eats)
            {
                eat.Eat();
            }

            Console.WriteLine("------------------------------");

            ISalary[] sals =
            {
                new Manager(),
                new Worker(),
            };

            foreach (var sal in sals)
            {
                sal.GetSalary();
            }

            Console.ReadLine();
        }
    }

    interface IWorker
    {
        void Work();
    }

    interface IEat
    {
        void Eat();
    }

    interface ISalary
    {
        void GetSalary();
    }

    class Manager : IWorker, IEat, ISalary
    {
        public void Eat()
        {
            Console.WriteLine("Manager Eat");
        }

        public void GetSalary()
        {
            Console.WriteLine("Manager get a salary");
        }

        public void Work()
        {
            Console.WriteLine("Manager Work");
        }
    }

    class Worker : IWorker, IEat, ISalary
    {
        public void Eat()
        {
            Console.WriteLine("Worker Eat");
        }

        public void GetSalary()
        {
            Console.WriteLine("Worker get a salary");
        }

        void IWorker.Work()
        {
            Console.WriteLine("Worker Work");
        }
    }

    class Robot : IWorker
    {
        public void Work()
        {
            Console.WriteLine("Robot Work");
        }
    }
}
