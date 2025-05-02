using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _028_Calculator
{
    internal class Calculator
    {
        //private int n1, n2;
        public static int Add(int n1, int n2) { return n1 + n2;}
        public static int Subtract(int n1, int n2) { return n1 - n2;}
        public static int Multiply(int n1, int n2) {return n1 * n2;}
        public static double Divide(int n1, int n2)
        {
            if (n1 == 0 || n2 == 0) return 0;
            else return n1 / n2;
        }
    }
}
