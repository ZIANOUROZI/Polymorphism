using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    internal class Cirkel : Geometri // Inherits from the abstract class geometri
    {
        public double Radius { get; set; } // This is a Property for radios of the circle

        public  Cirkel(double radius) // This is a constructor to set the radius when a cirkel object is created 
        {
            Radius = radius;
        }
        public override double Area() 
        {
            return Radius * Radius * Math.PI; // Overrides the area method to calculate the area of the circle          
        }      
    }
}
