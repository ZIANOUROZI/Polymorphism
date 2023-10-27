using Microsoft.VisualBasic;

namespace Polymorphism
{
    internal class Program
    {
        // Zia Nourozi Klass NET23
        static void Main(string[] args)
        {
            // I created five different shapes geometri instances and calls their methods to disply their behaviors
            Geometri MyCirkel = new Cirkel(5);
            Console.WriteLine("Cirkel: " + MyCirkel.Area());
            Console.WriteLine("Avrundat till: " + Math.Round(MyCirkel.Area(), 3));

            Geometri MyFyrkant = new Fyrkant(10);
            Console.WriteLine("Fyrkant: " + MyFyrkant.Area());
            Console.WriteLine("Avrundat till: " + Math.Round(MyFyrkant.Area(), 3));

            Geometri MyRektangel = new Rektangel(5, 8);
            Console.WriteLine("Rektangel: " + MyRektangel.Area());
            Console.WriteLine("Avrundat till: " + Math.Round(MyRektangel.Area(), 3));

            Geometri MyPrallellogram = new Parallellogram(5, 4);
            Console.WriteLine("Parallellogram: " + MyPrallellogram.Area());
            Console.WriteLine("Avrundat till: " + Math.Round(MyPrallellogram.Area(), 3));

            Geometri MyEllips = new Ellips(9, 7);
            Console.WriteLine("Ellips: " + MyEllips.Area());
            Console.WriteLine("Avrundat till: " + Math.Round(MyEllips.Area(), 5));
        }
    }
}