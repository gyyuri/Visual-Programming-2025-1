namespace _024_Class2
{

    class Product
    {
        //객체타입?: nullable(null값 가질 수 있음)
        public string? name; 
        public int price;

    }

    class MyMath
    {
        //static: 클래스 참조(객체 참조x) - 클래스 당 1개 생성
        public static double PI = 3.14;
    }

    class MyCalendar
    {
        //const: 상수-값이 변하지 않음, 클래스 참조(객체 참조X)
        public const int months = 12;
        public const int weeks = 52;
        public const int days = 365;

        public const double daysPerWeek = (double)days / weeks;
        public const double daysPerMonth = (double)days / (double)months;
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            //Product의 객체 P 생성 + P의 이름은 '시계', 가격은 10만원으로 세팅
            Product p = new Product();
            p.name = "시계";
            p.price = 100000;

            //객체 p의 이름과 가격을 출력 하시오.
            Console.WriteLine($"이름: {p.name}");
            Console.WriteLine($"가격: {p.price}");

            //MyMath 객체 생성
            MyMath m = new MyMath();
            Console.WriteLine(MyMath.PI);

            //MyCalendar 객체 생성
            MyCalendar c = new MyCalendar();
            Console.WriteLine(MyCalendar.daysPerMonth.ToString("F2"));
            //Console.WriteLine("{0:F2}",MyCalendar.daysPerMonth);

        }
    }
}
