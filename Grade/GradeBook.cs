using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grade
{

    //a class is a blueprint for creating objects
    class GradeBook
    {
        //type ctor = snippit for a new  default construtor tab 2 after 
        public GradeBook()
        {
             
        }
        //in this case grade is a var that is scoped to inside the curly brace and can be called only there
        public void AddGrade(float grade)
        {
            //this will add grade to the grades field
            grades.Add(grade);
        }


        //this allows us to store several items 
        //it comes from using System.Collections.Generic
        //its called a field and we gave it the name grades
        //could put = new List<float>(); initializes the field here
        List<float> grades = new List<float>(); 
    }
}
