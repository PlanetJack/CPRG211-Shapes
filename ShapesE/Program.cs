using ShapesE.Shapes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapesE
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Triangle triangle1;

            triangle1 = new Triangle("Red", 3.5, 10.5);

            string color = triangle1.Color;
            triangle1.Color = "cyan";

            double triangle1Area = triangle1.Area;
            Console.WriteLine("Area 1 :  " + triangle1Area);

            string formatted = string.Format("Area : {0:N2}", triangle1Area);
            Console.WriteLine(formatted);

            Console.WriteLine($"Area : {triangle1Area.ToString("N2")}\n" +
                $"abc");

            Rectangle rectangle1;

            rectangle1 = new Rectangle("Red", 10.5, 15.4);

            double rectangleArea = rectangle1.Area;

            Console.WriteLine("Rectangle area:  " + rectangleArea);
            
        }
    }
}
