using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baitap4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("#1. Trying to get a Singleton instance, called firstInstance.");
            Singleton firstInstance = Singleton.GetInstance;
            Console.WriteLine("--Invoke Print() method : ");
            firstInstance.Print();
            Console.WriteLine("#2. Trying to get another Singleton instance, called secondInstance.");
            Singleton secondInstance = Singleton.GetInstance;
            Console.WriteLine($"--Number of instance: {secondInstance.GetTotalInstances}");
            Console.Write("--Invoke Print() method : ");
            secondInstance.Print();
            if (firstInstance.Equals(secondInstance))
            {
                Console.WriteLine("=> The firstInstance and secondÍnstance are the same.");

            }
            else
            {
                Console.WriteLine("=> Different instances exist.");

            }
            Console.ReadLine();
        }
    }
}
