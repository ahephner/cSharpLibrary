using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._09_functionparams
{
    class Program
    {
        int multiply(int num1, int num2)
        {
            int result = num1 * num2;
            return result;
        }
        static void Main(string[] args)
        {
            //prog makes a new instance of program 
            //you need this to call functions made in the program class

            Program prog = new Program();



            //ref mod
            //this adds reference to our number var
            //without adding it to our function and call C# thinks we are giving it a copy 
            //of the number var not the actual number var
            //the value of the ref must be made initialized before calling the method
            int number = 12;
            addTen(ref number);
            Console.WriteLine(number);
            GreetPersons("aj", "dave", "mac");


            Console.WriteLine("multiple 2 and 6");
            Console.WriteLine(prog.multiply(2, 6));


            //since function is written in here don't need prog
            int math(int numb1, int numb2)
            {
                int result = numb1 + numb2;
                return result;
            }

            Console.WriteLine("add 2 and 6");
            Console.WriteLine(math(2, 6));

            //function that does not have a set amount of params
               void GreetPersons(params string[] names) { }

            //call this way could be hard
            

            



            Console.ReadLine();
        }


        static void addTen(ref int number)
        {
            number = number + 10;
        }
         

           
        }
       
    }

