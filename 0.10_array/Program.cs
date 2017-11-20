using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._10_array
{
    class Program
    {
        public int AddNumber(int number1, int number2)
        {
            int result = number1 + number2;
            return result; 
        }
        static void Main(string[] args)
        {



            Program prog = new Program();
            Console.WriteLine(prog.AddNumber(1, 5));


            //declared similar to variables with [] after datatype
            //setting the array size [3]
            string[] people = new string[2];
            //adding people to my array
            people[0] = "aj";
            people[1] = "jackie";
            

            foreach (string i in people)
            
                Console.WriteLine(i);



            string[] countries = new string[4];

            countries[0] = "USA";
            countries[1] = "Mexico ";
            countries[2] = "Japan";
            countries[3] = "England";

            //pull individual name
            Console.WriteLine(countries[1]);
            
            
            
            //short hand array writing

            int[] numbs = { 4, 5, 6, 7, 7, 9 };

            foreach (int i in numbs)
                Console.WriteLine(i);


            int[] exampleSort = { 12, 13, 100, 56 };

            //this sorts our array numbers in order
            //
            Array.Sort(exampleSort);

            foreach (int i in exampleSort)
                Console.WriteLine(i);
            Console.ReadLine();
        }
    }  
  }

