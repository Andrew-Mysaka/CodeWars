using System;
using System.Collections.Generic;
using System.Text;

namespace CodeWars.Kata_7_kyu
{
    class TwoToOne
    {
        public static string Longest(string s1, string s2)
        {
            string temp = s1 + s2;
            List<char> strList = new List<char>();

            foreach (var letter in temp)
            {
                if (!strList.Contains(letter))
                    strList.Add(letter);
            }
            strList.Sort();

            string result = "";
            foreach (var chr in strList)
                result += chr;

            return result;

            //string.Concat((s1 + s2).Distinct().OrderBy(x => x));
        }
    }
    //Take 2 strings s1 and s2 including only letters from ato z.Return a new sorted string,
    //the longest possible, containing distinct letters,

    //each taken only once - coming from s1 or s2.
}
