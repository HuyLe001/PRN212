using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baitap5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***Factory Method Pattern Demo.*** \n");
            List<AnimalFactory> animalFactoryList = new List<AnimalFactory>
            {
                new TigerFactory(),
                new LionFactory()
            };
            foreach (var animal in animalFactoryList)
            {
                animal.CreateAnimal().AboutMe();
            }
            Console.ReadLine();
        }
    }
}
