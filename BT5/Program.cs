using System;
using MyLibrary;

class Program
{
    static void Main()
    {
        int day = DateHelper.ReadPositiveInt("Nhap ngay: ");
        int month = DateHelper.ReadPositiveInt("Nhap thang: ");
        int year = DateHelper.ReadPositiveInt("Nhap nam: ");

        string weekday = DateHelper.DayOfWeek(day, month, year);
        Console.WriteLine("Thu trong tuan cua ngay " + day + "/" + month + "/" + year + " la: " + weekday);
    }
}
