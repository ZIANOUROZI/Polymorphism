using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    internal class Ellips : Geometri // Inherits from the abstract class geometri
    {
        public double AxelA { get; set; } //  This is a property to store the length of the (AxelA) of the ellipse
        public double AxelB { get; set; } // This is a property to store the length of the (AxelB) of the ellipse

        public Ellips(double axela, double axelb) // This is a constructor for lenght of AxelA and AxelB
        {
            AxelA = axela;
            AxelB = axelb;
        }
        public override double Area()
        {
            return AxelA * AxelB; // Overrides the Area method to calculate the area of the ellipse
        }
    }    
}
