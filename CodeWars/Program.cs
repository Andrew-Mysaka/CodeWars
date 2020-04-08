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
            // Console.WriteLine("HELLO I AM DONALD".IsUpperCase8());
            // Console.WriteLine(ArrayMadness.ArrayMadness8(new int[] {4, 5, 6}, new int[] {1, 2, 3}));
            // Console.WriteLine(FirstNonConsecutive.FirstNonConsecutive8(new int[] {1, 2, 3, 4, 6, 7, 8}));
            // Console.WriteLine(IsHeGonnaSurvive.Hero(10,5));
            // Console.WriteLine(GetDrinkByProfession.GetDrinkByProfession8("Jabroni"));
            // Console.WriteLine(Watermelon.Divide(4));
            // Console.WriteLine(TripleTrouble.TripleTrouble8("this", "test", "lock"));
            Console.WriteLine(BlueAndRedMarbles.GuessBlue(5, 5, 2, 3));
        }
    }
    public static class BlueAndRedMarbles
    {
        public static double GuessBlue(uint blueStart, uint redStart, uint bluePulled, uint redPulled)
            =>  (double) (blueStart - bluePulled) / (blueStart - bluePulled + redStart -redPulled);
        
        //You and a friend have decided to play a game to drill your statistical intuitions.The game works 
        //    like this:

        //You have a bunch of red and blue marbles.To start the game you grab a handful of marbles of each 
        //color and put them into the bag, keeping track of how many of each color go in. You take turns 
        //    reaching into the bag, guessing a color, and then pulling one marble out. You get a point if 
        //you guessed correctly.The trick is you only have three seconds to make your guess, so you have to 
        //think quickly.

        //    You've decided to write a function, guessBlue() to help automatically calculate whether you 
        //    should guess "blue" or "red". The function should take four arguments:

        //the number of blue marbles you put in the bag to start
        //the number of red marbles you put in the bag to start
        //the number of blue marbles pulled out so far (always lower than the starting number of blue marbles)
        //the number of red marbles pulled out so far(always lower than the starting number of red marbles)
        //guessBlue() should return the probability of drawing a blue marble, expressed as a float. For example, 
        //    guessBlue(5, 5, 2, 3) should return 0.6.
    }
}
