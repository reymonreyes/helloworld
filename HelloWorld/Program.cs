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
            ARITHMETIC OPERATORS
            + addition
            - subtraction
            * multiplication
            / division
        */
        static void Main(string[] args)
        {
            var addition = 1+1;
            var subtraction = 10-5;
            var multiplication = 2*5;
            var division = 10/2;
            Console.WriteLine("Addition: 1+1 = " + addition);
            Console.WriteLine("Subtraction: 10-5 = " + subtraction);
            Console.WriteLine("Multiplication: 2*5 = " + multiplication);
            Console.WriteLine("Division: 10/2 = " + division);
            Console.ReadLine();
        }
    }
}
