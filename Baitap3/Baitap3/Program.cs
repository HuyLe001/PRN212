﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baitap3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>()
            {
new Person{FirstName= "David", LastName="Simpson", Age=50},
new Person{FirstName= "Marge", LastName="Simpson", Age=45},
new Person{FirstName= "Lisa", LastName="Simpson", Age=19},
new Person{FirstName= "Jack", LastName="Simpson", Age=16},
            };
            Console.WriteLine("Items in list: {0}", people.Count);
            //foreach (Person p in people)
            //{
            //    Console.WriteLine(p);
            //}
            int a = 0;
            people.ForEach(person =>
            {
                a++;
                Console.WriteLine("{0}: {1}", a,person);
            });
        }
    }
}
