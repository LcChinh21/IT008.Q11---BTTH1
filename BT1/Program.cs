using System;
using MyLibrary;
class Program
{
    static void Main()
    {
        int n = ArrayUtilities.ReadPositiveInt("Nhap so phan tu mang: ");
        int[] a;
        a = new int[n]; ArrayUtilities.InputArray(a, n);
        Console.WriteLine("Tong so le trong mang: " + ArrayUtilities.SumOdd(a, n));
        Console.WriteLine("So nguyen to trong mang: " + ArrayUtilities.CountPrimes(a, n));
        Console.WriteLine("So chinh phuong nho nhat: " + ArrayUtilities.MinPerfectSquare(a, n));
    }
}
