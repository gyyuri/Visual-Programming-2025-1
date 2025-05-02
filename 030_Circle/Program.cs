namespace _030_Circle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CirCle donut = new CirCle(5);
            Console.WriteLine("도넛의 넓이: {0:F2}", donut.GetArea());

            CirCle pie = new CirCle(10);
            Console.WriteLine("파이의 넓이: {0:F2}", pie.GetArea());

            CirCle pizza = new CirCle(15);
            Console.WriteLine("피자의 넓이: {0:F2}", pizza.GetArea());
        }
    }
}
