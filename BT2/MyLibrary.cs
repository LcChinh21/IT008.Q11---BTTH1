using System;
namespace MyLibrary
{
    public static class MathHelper
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
        public static bool IsPrime(int x)
        {
            if (x < 2) return false;
            for (int i = 2; i * i <= x; i++)
            {
                if (x % i == 0) return false;
            }
            return true;
        }
        public static int SumPrimesLessThan(int n)
        {
            int sum = 0;
            for (int i = 2; i < n; i++)
            {
                if (IsPrime(i)) sum += i;
            }
            return sum;
        }
    }
}
