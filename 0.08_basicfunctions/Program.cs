using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._08_basicfunctions
{
    class Program
    {
        static void Main(string[] args)
        {
            //structure <visibility> <return type> <name>(<parameters>){
            //<function code>  
            //}

            //return type here is set to void which means
            //the function returns nothing
             void first()
            {
                Console.WriteLine("First Function");
            }

            //this is how you call function
            //if you have para's need to pass through
            first();


            //not a great example but this shows multiple returns
            //this assures that we always return somethign out of this function
            int number(int number1, int number2)
            {
                int result = number1 + number2;
                if (result > 1)
                {
                    return result;
                }

                return 0; 
                    }

            Console.WriteLine(number(8,0));
            Console.Read(); 
        }
    }
}
