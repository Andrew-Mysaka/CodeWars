using System;
using System.Linq;

namespace CodeWars
{
    partial class Program
    {
        public class KataArrayDiff
        {
            public static int[] ArrayDiff(int[] a, int[] b)
            {
                return a.Where(el => !b.Contains(el)).ToArray();
            }
        }
    }
}
