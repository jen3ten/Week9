using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week9_InheritancePractice_02292016
{
    class ChocChipCookie : Cookie       //A derived class of Cookie
    {
        //fields
        private int numChips;

        //constructor
        public ChocChipCookie()
        {
            this.numChips = 54;
            this.calories = 700;
        }

        //properties
        public int NumChips
        {
            get { return this.numChips; }
            set { this.numChips = value; }
        }

        //method
        public string WhoHasMoreCalories(int cookieCal, int sugarCal, int chocChipCal)
        {
            string answer = "";
            return answer;
        }
    }
}
