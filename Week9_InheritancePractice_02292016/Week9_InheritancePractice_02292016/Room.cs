using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week9_InheritancePractice_02292016
{
    class Room
    {
        //fields
        private double size;

        //property
        public double Size
        {
            get { return this.size; }
            set { this.size = value; }
        }

        //constructor
        public Room(double size)
        {
            this.Size = size;
        }

        //constructor
        public Room()
        {
            this.Size = 5;
        }


    }
}
