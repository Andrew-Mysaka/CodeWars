namespace CodeWars
{
    public class ArrayMadness
    {
        public static bool ArrayMadness8(int[] a, int[] b)
        {
            int res1 = 0;
            int res2 = 0;

            for (int i = 0; i < a.Length; i++)
            {
                res1 += a[i] * a[i];
            }
            for (int i = 0; i < b.Length; i++)
            {
                res2 += b[i] * b[i] * b[i];
            }
            return res1 > res2;
        }
        // a.Sum(x => x* x) > b.Sum(x => x* x*x);

        // Given two integer arrays a, b, both of length >= 1, create a program 
        // that returns true if the sum of the squares of each element in a 
        // is strictly greater than the sum of the cubes of each element in b.
    }
}