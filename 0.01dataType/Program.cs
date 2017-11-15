using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._01dataType
{
    class Program
    {
        static void Main(string[] args)
        {
            //strong typed! 

            bool t = true;

            //int has to be whole 
            int number = 12;

            short sh = 32767; //2^16
            int i = 0;

            byte by = 255; //2^8 
            char c = 'i'; //single character string is a list of linked char **note the single ' vs. "
            var anything = "variable";
            float f = 33.4f; //floating point integer must pur f explicit conversion after
            double d = 28.4; //64 bit decimal
            string fname = "Andrew";
            string lname = "hephner";

            //declaring here to use later
            int a;
            int b;
            string name; 


            Console.WriteLine("i = {0}, sh={1}", i, sh);
            Console.WriteLine(i + sh);
            Console.WriteLine(t);
            Console.WriteLine("Hello :"+ fname + " " + lname + " " + "and my favorite number is " + number);
            Console.WriteLine("Only Jackie calls me" + fname + " " + " please call me");
            //here i can change above info based off what user input is 
            fname = Console.ReadLine();

            Console.WriteLine("ok" + " " + fname);
            //again need this here to keep console up
            //without it the console goes away with out 
            //the ability to read the last writeline response

            //using declaration above
            Console.WriteLine("Whats your name?");
            name = Console.ReadLine();
            Console.WriteLine("What was your score in game 1?");
            
            //int.Parse()method takes string convert to int
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("What was your score in game 2?");
            b = int.Parse(Console.ReadLine());

            Console.WriteLine("Great" +" " + name + "your score was" +" "+ (a + b));
            Console.ReadLine();
            
        }
    }
}
