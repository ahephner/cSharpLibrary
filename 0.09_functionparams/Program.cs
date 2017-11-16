using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._09_functionparams
{
    class Program
    {
        static void Main(string[] args)
        {
            //ref mod
            //this adds reference to our number var
            //without adding it to our function and call C# thinks we are giving it a copy 
            //of the number var not the actual number var
            //the value of the ref must be made initialized before calling the method
            int number = 12;
            addTen(ref number);
            Console.WriteLine(number);
         
            HelloPeople("AJ", "rick");
           
            Console.ReadLine();
        }
        static void addTen(ref int number)
        {
            number = number + 10;
        }
       
        static void HelloPeople(params string[] name) { }

       
    }
}
