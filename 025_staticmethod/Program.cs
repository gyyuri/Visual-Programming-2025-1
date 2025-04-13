using System.ComponentModel.Design;

namespace _025_staticmethod
{

    

    internal class Program
    {
        static void Main(string[] args)
        {
            Date bd = new Date();

            bd.year = 2002;
            bd.month = 11;
            bd.day = 15;

            Console.WriteLine("귀하의 생일은 {0}째 되는 날입니다.", bd.DayOfYear());

            if (Date.IsLeapYear(2002) == true)
                Console.WriteLine("{0}년은 윤년입니다.", bd.year);
            else Console.WriteLine("{0}년은 평년입니다.", bd.year);
        }
    }
}
