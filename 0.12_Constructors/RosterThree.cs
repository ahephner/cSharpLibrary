using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._12_Constructors
{
    class RosterThree
    {
        //empty public constructor
        public RosterThree()
        {
            this.Name = "";
        }

        //this has overload
        public RosterThree(string name)
        {
            this.Name = name;
        }

        public string Name { get; set; }
    }

}
