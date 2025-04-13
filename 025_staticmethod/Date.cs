using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _025_staticmethod
{
    internal class Date
    {
        //filed 3개 생성 
        public int year, month, day;

        public static bool IsLeapYear(int y)
        {
            //윤년: 4로 나누어지고, 100으론 나누어지지 않지만 400으로 나눠지는 해
            return (y % 4 == 0) && (y % 100 != 0 || y % 400 == 0);
        }

        static int[] days = {0,31,59,90,120,151,181,212,243,273,304,334};

        public int DayOfYear()
        {
            //윤년이면 + 1
            //if (month > 2 & IsLeapYear(year))
                //return days[month - 1] + day + 1;
            //else
                //return days[month - 1] + day;

            //간소화 수식
            return days[month - 1] + day +
                (month > 2 & IsLeapYear(year) ? 1 : 0);
        }



    }
}
