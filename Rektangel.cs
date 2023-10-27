using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    internal class Rektangel : Geometri // Inherits from the abstract class geometri
    {
        public double Längd { get; set; } // This is a property to store the length of the rectangle
        public double Bredd { get; set; } // This is a property to store the width of the rectangle

        public Rektangel(double längd, double bredd) // This a constuctor for length and width
        {
            Längd = längd;
            Bredd = bredd;
        }
        public override double Area()
        {
            return Längd * Bredd; // Overrides the Area method to calculate the area of the rectangle
        }
    }
}
