using System;
namespace MyLibrary
{
    public static class DateHelper
    {
        public static int ReadPositiveInt(string message)
        {
            int n;
            do
            {
                Console.Write(message);
            } while (!int.TryParse(Console.ReadLine(), out n) || n <= 0);
            return n;
        }
        public static bool IsLeapYear(int year)
        {
            return (year % 4 == 0 && year % 100 != 0) || (year % 400 == 0);
        }
        public static int DaysInMonth(int month, int year)
        {
            if (month < 1 || month > 12) return -1;
            int[] days = { 31, IsLeapYear(year) ? 29 : 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            return days[month - 1];
        }
    }
}
