using System;
using System.Collections.Generic;
using System.Text;

namespace CodeWars.Kata_8_kyu
{
    class IsItANumber
    {
        public static bool IsDigit(string s)
        {
           return Double.TryParse(s, out _);
        }
    }
    //Given a string s, write a method(function) that will return true if 
    //its a valid single integer or floating number or false if its not.
}

