namespace _003_bmics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("키(cm): ");
            double h = double.Parse(Console.ReadLine());
            h /= 100;

            Console.Write("체중(kg): ");
            double w = double.Parse(Console.ReadLine());

            double bmi = w / (h * h);

            Console.WriteLine("BMI = " + bmi);
        }
    }
}
