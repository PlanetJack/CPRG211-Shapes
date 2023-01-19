using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapesE.Shapes
{
    internal class Triangle
    {
        private readonly int sides = 3;
        private string color;
        private double baseLength;
        private double heightLength;

        public string Color
        {
            get 
            {
                return this.color;
            }
            set
            {
                if ((value == "red" || value == "blue" || value == "green") == false)
                {
                    return;
                }

                this.color = value;
            }
        }


        public double Area 
        {
            get
            {
                double area;
                area = (this.baseLength * this.heightLength) / 2;

                return area;
            }

        } 
        public Triangle(string color, double baseLength, double heightLength)
        {
            this.color = color;
            this.baseLength = baseLength;
            this.heightLength = heightLength;
        }
    }
}
