using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._11_Access_Mod
{
    class Program
    {
        static void Main(string[] args)
        {
            Mazda mazda = new Mazda("M-6", 2017, 2000);

            mazda.MazdaDetails();

            Console.ReadLine();
        }
    }
}
