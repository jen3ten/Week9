using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week9_InheritancePractice_02292016
{
    class Kitchen : Room
    {
        //fields
        private int numAppliances;
         //properties
        public int NumAppliances
        {
            get { return this.numAppliances; }
            set { this.numAppliances = value; }
        }
        //constructor
        //public Kitchen(int numAppliances) : base (543.25)

        public Kitchen (int numAppliances)  //why doesn't this work?
        {
            this.NumAppliances = numAppliances;
        }

       
    }
}
