using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._03_Conditional_if_else_statement
{
    class Program
    {
        static void Main(string[] args)
        {

            int number;

            Console.WriteLine("Please enter a number between 1-10");
            number = int.Parse(Console.ReadLine());

            //Like to do console.log(number); do the following; 
            // Console.WriteLine(number);
            Console.WriteLine("Please enter a number between 0 and 10:");
            number = int.Parse(Console.ReadLine());

            if (number > 10)
                Console.WriteLine("Hey! The number should be 10 or less!");
            else
                if (number < 0)
                Console.WriteLine("Hey! The number should be 0 or more!");
            else
                Console.WriteLine("Good job!");


            //shorter way to do above
            //noticed that it asks both questions before giving a response to first if
            if ((number <= 10) && (number >= 0))
                Console.WriteLine("awesome");
            else
                Console.WriteLine("that is wrong");
            Console.Read();
        }
    }
}
