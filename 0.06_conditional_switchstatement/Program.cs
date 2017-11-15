using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._06_conditional_switchstatement
{
    class Program
    {
        static void Main(string[] args)
        {
            //BONUS LEARNING CHANGE COLORS!!!
            //sets the background
            Console.BackgroundColor = ConsoleColor.Blue;
            //makes entire back ground color set above
            Console.Clear();
            //set foreground or text in this example
            Console.ForegroundColor = ConsoleColor.White;



            //switch is like a bunch of options to run when the input is given
            //in this case we know that num = 1 so on run we get statement in
            //case 1
            int num = 1;

            switch (num)
            {
                case 0:
                    Console.WriteLine("The number is 0");
                    break;
                case 1:
                    Console.WriteLine("the number is one");
                    break;
            }

            Console.WriteLine("Do you like Tacos? (yes/maybe/no)");
            string input = Console.ReadLine();
            //input.TOLower() brings back user data as lower case
            //this prevents not matching case statements
            switch (input.ToLower())
            {
                //because we are passing a string here need ""
                case "yes":
                    Console.WriteLine("It is my favorite");
                    break;
                case "maybe":
                    Console.WriteLine("How can you not know?");
                    break;
                case "no":
                    Console.WriteLine("Too spicy?");
                    break;
            }

            Console.ReadKey();
        }
    }
}
