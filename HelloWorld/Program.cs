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
            VARIABLE & DATA TYPES
            - Variable declaration
            - Data types
              - int
              - float
              - char
              - string
              - bool
        */
        static void Main(string[] args)
        {
            var myName = "John";
            int age = 12;
            float height = 1.45F;
            char middleInitial = 'D';
            string favoriteFood = "Spaghetti";
            bool doYouLikeDogs = true;

            Console.WriteLine("Hello " + myName);
            Console.WriteLine("You are " + age + " years old.");
            Console.WriteLine("Your height is " + height + " meters.");
            Console.WriteLine("Your middle initial is " + middleInitial + ".");
            Console.WriteLine("Your favorite food is " + favoriteFood + ".");
            Console.WriteLine("Do you like dogs? " + doYouLikeDogs);
            Console.ReadKey();
        }
    }
}
