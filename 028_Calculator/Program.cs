namespace _028_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = 10;
            int num2 = 5;

            int sum = Calculator.Add(num1, num2);
            int difference = Calculator.Subtract(num1, num2);
            int product = Calculator.Multiply(num1, num2);
            double quotient = Calculator.Divide(num1, num2);

            Console.WriteLine("덧셈: " + sum);
            Console.WriteLine("뺄셈: " + difference);
            Console.WriteLine("곱셈: " + product);
            Console.WriteLine("나눗셈: " + quotient);
        }
    }
}
