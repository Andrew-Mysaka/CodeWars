using System;
using System.Collections.Generic;
using System.Text;

namespace CodeWars.Kata_7_kyu
{
    class AutomorphicNumber
    {
        public static string Automorphic(int n)
        {
            int sqr = n * n;
            int numberDigits = 0;
            int nn = n;

            do
            {
                nn /= 10;
                numberDigits++;
            }
            while (nn > 1);


            bool flag = true;
            for (int i = 0; i < numberDigits; i++)
            {
                Console.WriteLine("n: " + n);
                Console.WriteLine("sqr: " + sqr);
                if (n % 10 == sqr % 10)
                {
                    n /= 10;
                    sqr /= 10;
                    continue;
                }
                else
                {
                    flag = false;
                    break;
                }
            }

            return flag ? "Automorphic" : "Not!!";

            //public static string Automorphic(int n) => (n * n).ToString().EndsWith(n.ToString()) ? "Automorphic" : "Not!!";
        }
    }
    //A number is called Automorphic number if and only if its square
    //ends in the same digits as the number itself.
}
