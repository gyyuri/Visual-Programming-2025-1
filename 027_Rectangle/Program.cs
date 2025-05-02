using System.Drawing;

namespace _027_Rectangle
{
    internal class Program
    {
        class Rectangle
        {
            private int width, height;

            public Rectangle(int width, int height)
            {
                this.width = width;
                this.height = height;
            }

            public int GetArea()
            {
                return width*height;
            }
            public int GetPerimeter()
            {
                return (width*2) + (height*2);
            }
        }


        static void Main(string[] args)
        {
            Rectangle rect = new Rectangle(5,3);
            double area = rect.GetArea();
            double perimeter = rect.GetPerimeter();

            Console.WriteLine("넓이: " + area);
            Console.WriteLine("둘레: " + perimeter);
        }
    }
}
