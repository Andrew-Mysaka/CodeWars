using System;
using System.Collections.Generic;
using System.Text;

namespace CodeWars.Kata_6_kyu
{
    class IsANumberPrime
    {
        public static bool IsPrime(int n)
        {
            if (n < 2) return false;

            int maximumDividor = (int)Math.Sqrt(n) + 1;

            for (int i = 2; i < maximumDividor; i+=2)
            {
                if (n % i == 0) return false;
            }
            
            return true;
        }
    }
   // Define a function that takes one integer argument and returns logical
   // value true or false depending on if the integer is a prime.

    //Per Wikipedia, a prime number (or a prime) is a natural number greater
    //than 1 that has no positive divisors other than 1 and itself.
}
