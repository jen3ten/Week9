using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week9_InheritancePractice_02292016
{
    class SugarCookie : Cookie      //A derived class of Cookie
    {
        //fields
        private string sugarColor;

        //constructor
        public SugarCookie(string color)
        {
            this.sugarColor = color;
            this.size = 8;
            this.calories = 50;
            this.sugarGrams = 15;
        }

        //properties
        public string SugarColor
        {
            get { return this.sugarColor; }
            set { this.sugarColor = value; }
        }
    }
}
