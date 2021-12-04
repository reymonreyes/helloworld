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
            LOGICAL OPERATORS
            &   AND
            |   OR
            &&  conditional AND
            ||  conditional OR
            !   NOT
            ?:  ternary conditional
        */
        static void Main(string[] args)
        {
            //Console.WriteLine("false & true is " + (false & RightHand()));
            //Console.WriteLine("true | false is " + (true | RightHand()));
            //Console.WriteLine("true && false is " + (false && RightHand()));
            //Console.WriteLine("true || RightHand() is " + (true || RightHand()));
            //Console.WriteLine("false & RightHand() is " + (false & RightHand()));
            //Console.WriteLine("!false is " + (!false));
            Console.WriteLine("true ? true : false is " + (true ? true : false));
            
            Console.ReadLine();
        }

        static bool RightHand()
        {
            Console.WriteLine("This is a RightHand method.");
            return false;
        }
    }
}
