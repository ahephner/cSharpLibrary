using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._12_Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            //Construcot Info: 
            //There is no return type
            //Name matchs name of class
            //Help set default value

            //Object Roster one
            //creates roster one playerOne then puts them in an array
            //created Roster requirments on Roster
            Roster playerOne = new Roster();
            playerOne.name = "Rex Grossman";
            playerOne.number = 8;

            Roster playerTwo = new Roster();
            playerTwo.name = "Brian Urlacher";
            playerTwo.number = 54;

            //here we are passing the which one to target with {0}
            //then the playerOne.name or .number is telling it what to display
            Console.WriteLine("{0} and {1} were great players", playerOne.number, playerTwo.name);
            

            //Roster two

            RosterTwo p1 = new RosterTwo();
            p1.name = "Lance Briggs";

            RosterTwo p2 = new RosterTwo();
            p2.name = "Robbie Gould";

            Console.WriteLine("{0} was an Outside LB and {1}was the best kicker", p1.name, p2.name);
            Console.WriteLine(p1.name.Length + " " + p2.name.Length);

            //Roster 3
            //here we just added in the params for the names because thats how we declared it in Roster 3 
            
            RosterThree hofPlayer1 = new RosterThree("Dick Butkus");
            RosterThree hofPlayer2 = new RosterThree("Gale Sayers");

            Console.WriteLine("{0} and {1} are two notable Bears Hall of Famers!", hofPlayer1.Name, hofPlayer2.Name);
            Console.ReadLine();
        }
    }
}
