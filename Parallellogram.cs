using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    internal class Parallellogram : Geometri // Inherits from the abstract class geometri
    {
        public double Bas { get; set; } // This is a Property to store the base length of the parallelogram
        public double Höjd { get; set; } // This is a  Property to store the height of the parallelogram

        public Parallellogram(double bas, double höjd) // This is a constructor for height and lenght
        {
            Bas = bas;
            Höjd = höjd;
        }
        public override double Area()
        {
            return Bas * Höjd; // Overrides the Area method to calculate the area of the parallelogram
        }
    }
}
