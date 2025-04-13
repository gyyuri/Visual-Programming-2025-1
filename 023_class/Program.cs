namespace _023_class
{
    public class Program
    {
        //C#에선 클래스가 외부,내부,다른 파일(같은 프로젝트 내)에 있어도 상관 없음
        class Date
        {
            private int year, month, day;

            
            public void SetYear(int year)  //void: 리턴값 없음
            {
                //this.year = private에서 정의한 변수(현재 클래스에서의 변수year)
                this.year = year;
            }

            public int GetYear()
            {
                return this.year;
            }

            public void PrintDate()
            {
                Console.WriteLine("{0}년 {1}월 {2}일", year, month, day);
            }

            //생성자(초기화)
            public Date()
            {
                year = 1;
                month = 1;
                day = 1;
            }
            public Date(int y, int  m, int d)
            {
                year = y;
                month = m;
                day = d;
            }
        }  

        static void Main(string[] args)
        {
            Date a = new Date();
            a.SetYear(2025);
            Console.WriteLine(a.GetYear());
            a.PrintDate();

            Date b = new Date();
            b.PrintDate();

            Date c = new Date(2025, 4, 7);
               c.PrintDate();
        }
    }
}
