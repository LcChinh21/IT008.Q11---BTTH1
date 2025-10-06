using System;
using MyLibrary;
class Program
{
    static void Main()
    {
        int day = DateHelper.ReadPositiveInt("Nhap ngay: ");
        int month = DateHelper.ReadPositiveInt("Nhap thang: ");
        int year = DateHelper.ReadPositiveInt("Nhap nam: ");
        if (DateHelper.IsValidDate(day, month, year))
            Console.WriteLine("Ngay thang nam hop le.");
        else
            Console.WriteLine("Ngay thang nam khong hop le.");
    }
}