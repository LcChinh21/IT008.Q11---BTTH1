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

        public static bool IsValidDate(int day, int month, int year)
        {
            if (month < 1 || month > 12) return false;
            if (day < 1) return false;
            int[] daysInMonth = { 31, IsLeapYear(year) ? 29 : 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            return day <= daysInMonth[month - 1];
        }

        public static string DayOfWeek(int day, int month, int year)
        {
            if (!IsValidDate(day, month, year)) return "Khong hop le";

            if (month < 3)
            {
                month += 12;
                year -= 1;
            }

            int k = year % 100;
            int j = year / 100;
            int h = (day + 13 * (month + 1) / 5 + k + k / 4 + j / 4 + 5 * j) % 7;

            string[] days = { "Thu 7", "Chu Nhat", "Thu 2", "Thu 3", "Thu 4", "Thu 5", "Thu 6" };
            return days[h];
        }
    }
}
