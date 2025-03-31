namespace _007_Format
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("안녕하세요 C# 수업 중 입니다.");
            Console.WriteLine("10이하의 소수: {0},{1},{2},{3}", 2,3,5,7);
            //{0} {1} -> {}안의 숫자는 ""가 끝난후 ,로 구분되는 문자열의 순서를 의미 

            string s = String.Format("10이하의 소수: {0},{1},{2},{3}", 2,3,5,7);
           

            Console.WriteLine(s);

            int v1 = 100;
            double v2 = 1.234;

            //Console.WriteLine(v1, v2); → error
            //출력할땐 무조건 하나의 문장 형태로 출력해야 함(,(X), +(O))

            Console.WriteLine("\nv1 = " + v1 + ", v2 = " + v2);
            //문자열 + 숫자 : 숫자가 문자열로 변환됨

            Console.WriteLine("v1 = {0}, v2 = {1}", v1, v2);

            Console.WriteLine($"v1 = {v1}, v2 = {v2}");


            double x = 123456789.567;
            Console.WriteLine("{0:C}", x); //C(Current): 통화
            Console.WriteLine("{0:E}", x); //지수형
            Console.WriteLine("{0:F2}", x); //F: 소수점 (ex.F2 : 소수점 2자리까지)
            Console.WriteLine("{0:N2}", x); //N(Number): 천단위 구분기호
            Console.WriteLine("{0:#,#.##}", x);
            Console.Write("{0:#,#.###}", 12345.6789);

        }
    }
}
