using System;
using System.Collections.Generic;
using System.Text;

namespace CodeWars.Kata_7_kyu
{
    class ArrayLeaders
    {
        public static int[] ArrayLeader(int[] numbers)
        {
            List<int> results = new List<int>();

            for (int i = 0; i < numbers.Length; i++)
            {
                int sum = 0;
                for (int j = i+1; j < numbers.Length; j++)
                {
                    sum += numbers[j];
                }

                if (numbers[i] > sum)
                {
                    results.Add(numbers[i]);
                }
            }
            
            return results.ToArray();
        }
        // public static int[] ArrayLeaders(int[] n) => n.Where((x, i) => x > n.Skip(i + 1).Sum()).ToArray();
    }
    // An element is leader if it is greater than The Sum all the
    // elements to its right side.
}
