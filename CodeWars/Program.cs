using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace CodeWars
{
    class Program
    {
        static void Main(string[] args)
        {
            // ArrayDiff.ArrayDiff6(new int[] { 1, 2 }, new int[] { 1 });
            // DifferenceInAges.DifferenceInAges8(new int[] {82, 15, 6, 38, 35});
            // RemoveEveryOther.RemoveEveryOther8(new object[] { "Hello", "Goodbye", "Hello Again"});
            //  Console.WriteLine("hello 133wOrld".ToAlternatingCase8());
        }
    }

    public static class ToAlternatingCase
    {
        public static string ToAlternatingCase8(this string s)
        {
            int ln = s.Length;
            string str = "";

            for (int i = 0; i < ln; i++)
            {
                if (s[i] >= 'a' && s[i] <= 'z')
                {
                    str += (char) (s[i] - 32);
                }

                else if (s[i] >= 'A' && s[i] <= 'Z')
                {
                    str += (char) (s[i] + 32);
                }
                else
                {
                    str += (char)s[i];
                }
            }
            return str;
            // return string.Concat(s.Select(c => char.IsUpper(c) ? char.ToLower(c) : char.ToUpper(c)));

            //Define String.prototype.toAlternatingCase(or a similar function / method such as to_alternating_case / toAlternatingCase / ToAlternatingCase in your selected language; see the initial solution for details) such that each lowercase letter becomes uppercase and each uppercase letter becomes lowercase.For example:

            //"hello world".ToAlternatingCase() == "HELLO WORLD"
            //"HELLO WORLD".ToAlternatingCase() == "hello world"
            //"hello WORLD".ToAlternatingCase() == "HELLO world"
            //"HeLLo WoRLD".ToAlternatingCase() == "hEllO wOrld"
            //"12345".ToAlternatingCase() == "12345" // Non-alphabetical characters are unaffected
            //"1a2b3c4d5e".ToAlternatingCase() == "1A2B3C4D5E"
            //"String.ToAlternatingCase".ToAlternatingCase() == "sTRING.tOaLTE
        }
    }
}
