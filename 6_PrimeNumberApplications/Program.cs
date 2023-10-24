using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_PrimeNumberApplications
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Prime Number Applications - Asal Sayı Uygulamaları

            //Girilen değerin asal olup olmadığını kontrol eden program.
            //IsPrimeNumberWriter();

            //2'den 100'e kadar olan asal sayıları yazdıran program.
            //ThousandPrimeNumber();

            #endregion
            Console.ReadLine();
        }

        private static void IsPrimeNumberWriter()
        {
            if (IsPrimeNumber(7))
            {
                Console.WriteLine("This is a prime number");
            }
            else
            {
                Console.WriteLine("This is not a prime number");
            }
        }

        static bool IsPrimeNumber(int number)
        {
            bool result = true;
            for (int i = 2; i <= number - 1; i++)
            {
                if (number % i == 0)
                {
                    result = false;
                    i = number; // asal olmayan sayı bulduğun i yi number a eşitleyecek ve döngü bitecek.
                }

            }

            return result;
        }

        static void ThousandPrimeNumber()
        {
            for (int i = 2; i <= 100; i++)
            {
                bool primeControl = true;
                for (int j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        primeControl = false;
                        break;
                    }
                }
                if (primeControl)
                {
                    Console.WriteLine(i + " Prime Number");

                }
            }
        }
    }
}
