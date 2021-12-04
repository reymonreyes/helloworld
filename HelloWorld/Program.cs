using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Program
    {
        /*
            COMPARISON OPERATORS
            ==  equals
            !=  not equals
            <   less than
            <=  less than or equal
            >   greater than
            >=  greater than or equal
        */
        static void Main(string[] args)
        {
            Console.WriteLine("1 == 1 is " + (1 == 1));
            Console.WriteLine("1 != 1 is " + (1 != 1));
            Console.WriteLine("2 < 3 is " + (2 < 3));
            Console.WriteLine("2 <= 2 is " + (2 <= 2));
            Console.WriteLine("2 > 1 is " + (2 > 1));
            Console.WriteLine("1 >= 1 is " + (1 >= 1));

            Console.ReadLine();
        }
    }
}
