using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace CodeWars.Kata_7_kyu
{
    class ListFiltering
    {
        public static IEnumerable<int> GetIntegersFromList(List<object> listOfItems)
        {
            List<int> result = new List<int>();

            foreach (var item in listOfItems)
            {
                if (item is int)
                {
                    result.Add((int)item);
                    Console.WriteLine(item);
                }
            }
            return result;
        }
    }
    //In this kata you will create a function that takes a list of non-negative 
    //integers and strings and returns a new list with the strings filtered out.
}
