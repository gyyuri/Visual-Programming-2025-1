using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _027_2__Rectangle
{
    internal class Rectangle
    {
        private double width, height;

        public Rectangle(double width, double height)
        {
            this.width = width;
            this.height = height;
        }

        public double GetArea() { return width * height; }
        public double GetPerimeter() { return (width * 2) + (height * 2); }
    }
}
