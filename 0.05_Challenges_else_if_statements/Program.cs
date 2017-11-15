using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._05_Challenges_else_if_statements
{
    class Program
    {
        static void Main(string[] args)
        {
            int score;

            Console.WriteLine("Please rate our app 1-10");
            score = int.Parse(Console.ReadLine());

            //rember JS fundies! I got stuck here at first using && when entering a score outside 0 or 10
            //it wouldnt run reason number had to be both above 11 and 0 at sametime
            //the || allows for either its below 0 or above 11
            if((score <= 0) || (score >= 11))
                Console.WriteLine("Sorry that is outside our scoring system?");
            else
                 if ((score >= 7) && (score == 10))
                Console.WriteLine("Great!");
            else
                if ((score <= 6) && (score >= 4))
                Console.WriteLine("Give us a second chance please");
            else
                if ((score <= 3) && (score == 0))
                Console.WriteLine("We are sorry!");
           
             

            Console.Read();
           
        }
    }
}
