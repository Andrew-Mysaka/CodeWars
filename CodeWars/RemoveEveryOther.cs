using System;

namespace CodeWars
{
    public static class RemoveEveryOther
    {
        public static object[] RemoveEveryOther8(object[] arr)
        {
            int round = (int)Math.Ceiling((double)arr.Length / 2);
            object[] array = new object[round];
            int j = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (i % 2 == 0)
                {
                    array[j] = arr[i];
                    j++;
                }
            }
            return array;

            //return arr.Where((e, i) => i % 2 == 0).ToArray();

        }
        //Take an array and remove every second element out of that array.Always keep the first 
        //element and start removing with the next element.

        //    Example:

        //my_list = ['Keep', 'Remove', 'Keep', 'Remove', 'Keep', ...]
        //None of the arrays will be empty, so you don't have to worry about that!
    }
}