using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week9_InheritancePractice_02292016
{
    class Cookie        //The base class
    {
        //fields
        protected double size;
        protected int calories;
        protected double sugarGrams;

        //constructor
        public Cookie()
        {
            this.size = 4.5;
            this.calories = 250;
            this.sugarGrams = 25.5;
        }

        //properties
        public double Size
        {
            get { return this.size; }
            set { this.size = value; }
        }

        public int Calories
        {
            get { return this.calories; }
            set { this.calories = value; }
        }

        public double SugarGrams
        {
            get { return this.sugarGrams; }
            set{ this.sugarGrams = value; }
        }

    }
}
