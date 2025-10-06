using System;
using MyLibrary;
class Program
{
    static void Main()
    {
        int n = MathHelper.ReadPositiveInt("Nhap so nguyen duong n: ");
        int sum = MathHelper.SumPrimesLessThan(n);
        Console.WriteLine("Tong cac so nguyen to nho hon " + n + " la: " + sum);
    }
}
