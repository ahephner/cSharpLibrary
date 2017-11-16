using System;
//needed for Array List
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._07_loops
{
    class Program
    {
        static void Main(string[] args)
        {
            //While Loop 

            int number = 0;


            while (number <= 5) 
            {
                Console.WriteLine(number);
                //walk it through
                number = number + 1;
            }
        
            //for loop
            int go = 10;

            for (int i = 0; i < go; i++)
                Console.WriteLine(i);

            

            //foreachloop
            //need using System.Collections; for ArrayList
            ArrayList list = new ArrayList();
            //
            list.Add("Test Person");
            list.Add("AJ Hephner");
            list.Add("BB Dog");

            foreach(string name in list)

            Console.WriteLine(name);

            Console.ReadLine();
        }
    }
}
