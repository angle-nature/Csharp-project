using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Class1
    {
        static void Main(string[] args)
        {
            Cat c1 = new Cat("Tom");
            Cat c2 = new Cat("Jaary");
            Cat c3 = new Cat("Mackel");
            Cat c4 = new Cat("Hury");

            Cat[] cat = { c1,c2,c3,c4 } ;
      
            foreach(Cat c in cat)
            {
                Console.WriteLine(c.name);
            }
            Console.ReadKey();
        }

    }
}
