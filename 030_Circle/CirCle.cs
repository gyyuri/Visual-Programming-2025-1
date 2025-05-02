using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _030_Circle
{
    internal class CirCle
    {
        private double radius;
        private static double PI = 3.14; //굳이 이거 안 하고

        public CirCle(double radius)
        {
            this.radius = radius;
        }

        public double GetArea()
        {
            return PI * (radius*radius);
        }
    }
}
