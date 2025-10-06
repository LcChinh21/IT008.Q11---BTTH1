using System;
namespace MyLibrary
{
    public class ArrayUtilities
    {
        public static int ReadPositiveInt(string message)
        {
            int n;
            do
            {
                Console.WriteLine(message);
                n = int.Parse(Console.ReadLine());
            }
            while (n <= 0);
            return n;
        }
        public static void InputArray(int[] a, int n)
        {
            for (int i = 0; i < n; i++)
            {
                a[i] = int.Parse(Console.ReadLine());
            }
        }
        public static int SumOdd(int[] a, int n)
        {
            int res = 0;
            for (int i = 0; i < n; i++)
            {
                if (a[i] % 2 != 0)
                {
                    res += a[i];
                }
            }
            return res;
        }
        public static bool isPrime(int x)
        {
            if (x < 2) return false;
            for (int i = 2; i < x / 2; i++)
            {
                if (x % i == 0) return false;
            }
            return true;
        }
        public static int CountPrimes(int[] a, int n)
        {
            int cnt = 0;
            for (int i = 0; i < n; i++)
            {
                if (isPrime(a[i])) cnt++;
            }
            return cnt;
        }
        public static bool isPerfectSquare(int x)
        {
            double temp = Math.Sqrt(x);
            int IntTemp = (int)temp;
            if (x == IntTemp) return true;
            else return false;
        }
        public static int MinPerfectSquare(int[] a, int n)
        {
            int min = -1;
            for (int i = 0; i < n; i++)
            {
                if (isPerfectSquare(a[i]))
                {
                    if (a[i] < min) min = a[i];
                }
            }
            return min;
        }
    }
}