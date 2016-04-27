using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week9_InheritancePractice_02292016
{
    class Program
    {
        static void Main(string[] args)
        {
            Cookie cookie = new Cookie();
            SugarCookie sugar = new SugarCookie("green");
            ChocChipCookie chocChip = new ChocChipCookie();

            Console.WriteLine("This cookie has {0} calories, {1} size and {2} sugar grams.", cookie.Calories, cookie.Size, cookie.SugarGrams);
            Console.WriteLine("This sugar cookie has {0} calories, {1} size and {2} sugar grams.  It is {3}", sugar.Calories, sugar.Size, sugar.SugarGrams, sugar.SugarColor);
            Console.WriteLine("This choc chip cookie has {0} calories, {1} size and {2} sugar grams.  It has {3} choc chips.", chocChip.Calories, chocChip.Size, chocChip.SugarGrams, chocChip.NumChips);


        }
    }
}
