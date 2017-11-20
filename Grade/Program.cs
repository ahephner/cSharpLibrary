using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grade
{
    class Program
    {
        static void Main(string[] args)
        {
            //classes hold state and behavior
            //state is data
            //behavior are methods or functions
            //this is the main entry point you can create other classes to be called here by creating new files
            //could call a new class outside of this brace but the convention is to create a new file

            GradeBook book = new GradeBook();
            
                book.AddGrade(89);
            book.AddGrade(45);

                //the f converts the double to a float since we declared on GradeBook to take float
                book.AddGrade(90.4f);
            
        }
    }
}
