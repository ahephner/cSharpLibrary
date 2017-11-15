using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._04_Conditional_if_else_if_statement
{
    class Program
    {
        static void Main(string[] args)
        {
            int cutler = 6;
            int mitch = 10;
            int rex = 8;

            if (cutler > rex)
                Console.WriteLine("Rex Grossman threw a lot of pics and fumbled so we got Cutler");
            else
                if (1 > cutler)
                Console.Write("Cutler became the all time leading qb in all stats including interceptions so we drafted Mitch");
            else
                if (mitch > 4)
                Console.WriteLine("Mitch is a rookie qb");
            else
                Console.WriteLine("its hopeless");

            Console.ReadLine();
        }
    }
}
