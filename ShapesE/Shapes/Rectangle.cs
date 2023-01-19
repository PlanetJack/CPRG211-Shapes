using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapesE.Shapes
{
    /// <summary>
    /// Represents a rectangle
    /// </summary>
    /// <remarks> Author : Kihyun Kim </remarks>
    /// <remarks> Date: January 19, 2023</remarks>
    internal class Rectangle
    {
        private readonly int sides = 4;
        private string color;
        private double width;
        private double height;

        public double Area
        {

            get
            {
                double area;

                area = width * height;

                return area;
            }
        }
        
        /// <summary>
        /// Initializes a Retangle object with a color, width, and height.
        /// </summary>
        /// <param name="color">Sets rectangle to this color. Must be a valid color name.</param>
        /// <param name="width">Sets rectangle to this width. </param>
        /// <param name="height">Sets rectangle to this height. </param>
        
       
        public Rectangle(string color, double width, double height)
        {
            this.color = color;
            this.width = width;
            this.height = height;
        
        }
    }
}
