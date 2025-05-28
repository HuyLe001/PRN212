using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baitap2
{
    internal class MyClass
    {
        public void Display<T,U>(T msg, U value)
        {
            Console.WriteLine($"{msg} : {value}");
        }        
    }
}
