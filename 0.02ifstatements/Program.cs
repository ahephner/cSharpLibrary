using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._02ifstatements
{
    class Program
    {
        static void Main(string[] args)
        {
            //based on boolean must have true or false answer
            //you can get a true or false answer by using logic as in #2


            bool rain = true;
            bool dark = false;

            if (rain)
                Console.WriteLine("its wet");
            else
                Console.WriteLine("dry out");

            //dark is false throw to else
            if (dark == true)
                Console.WriteLine("turn on the lights");
            else
                Console.WriteLine("need some shades");

            //dark = false both not both are equal to eachother so it throws to else
            if (rain && dark)
                Console.WriteLine("wet and dark out");
            else
                Console.WriteLine("rainy day");

            //dark does not equal true run first 
            if (!dark == true)
                Console.WriteLine("lights please");
            else
                Console.WriteLine("its bright");








            
        }
    }
}
