// DataTime 클래스
// MSDN

using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            // DataTime
            // 날짜와 시간으로 표시된 시간을 나타낸다.
            // DataTime(year, month, day)
            // year
            // 년(1 ~ 9999)
            // month
            // 월(1 ~ 12)
            // day
            // 일
            DateTime date1 = new DateTime(2010, 8, 18);
            Console.WriteLine(date1.ToString());
        }
    }
}
