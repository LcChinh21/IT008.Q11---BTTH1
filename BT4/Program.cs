using System;
using MyLibrary;
class Program
{
    static void Main()
    {
        int month = DateHelper.ReadPositiveInt("Nhap thang: ");
        int year = DateHelper.ReadPositiveInt("Nhap nam: ");
        int days = DateHelper.DaysInMonth(month, year);
        if (days == -1)
            Console.WriteLine("Thang khong hop le.");
        else
            Console.WriteLine("So ngay cua thang " + month + " nam " + year + " la: " + days);
    }
}
