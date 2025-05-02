namespace _027_2__Rectangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rectangle rect = new Rectangle(5, 3);
            double area = rect.GetArea();
            double perimeter = rect.GetPerimeter();

            Console.WriteLine("넓이: " + area);
            Console.WriteLine("둘레: " + perimeter);
        }
    }
}
