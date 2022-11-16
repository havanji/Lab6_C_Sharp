using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6_C_Sharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cat barsic = new Cat(5, "Brown", 2);
            Dog knopa = new Dog(2, "White", 1);

            Console.WriteLine(barsic.ToString());
            Console.WriteLine(barsic.MakeSound());
            Console.WriteLine(knopa.ToString());
            Console.WriteLine(knopa.MakeSound());

            Console.ReadKey();

        }
    }
}
