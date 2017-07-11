using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumberMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the side of the prime number matrix: ");
            int totalNumbers = int.Parse(Console.ReadLine());

            int total = 0;

            int[] primes = new int[totalNumbers*totalNumbers];

            for(int i=2; ; i++)
            {
                if (isPrime(i))
                {
                    primes[total] = i;
                    total++;
                }

                if (total == totalNumbers*totalNumbers)
                    break;
            }

            Console.WriteLine("Prime Number Matrix: ");

            int ctr = 0;
            foreach(int i in primes)
            {
                ctr++;
                Console.Write(i + " ");
                if (ctr % totalNumbers == 0)
                    Console.WriteLine();
            }

            Console.ReadKey();

        }

        public static bool  isPrime(int number)
        {
            bool itIsPrime = true;
            for (int i = 2; i < number; i++)
                if (number % i == 0)
                    itIsPrime = false;

            return itIsPrime;
        }
    }
}
