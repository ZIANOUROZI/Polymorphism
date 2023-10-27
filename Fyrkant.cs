using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    internal class Fyrkant : Geometri // Inherits from the abstract class geometri
    {
        public double Sida { get; set; } // This is a Property to store the side lenght of the square
        public Fyrkant(double sida) // This is a constructor to set the lenght when a fyrkant object is created
        {
            Sida = sida;
        }
        public override double Area()
        {
            return Sida * Sida; // Overrides the Area method to calculate the area of the square
        }
    }
}
