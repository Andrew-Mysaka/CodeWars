namespace CodeWars
{
    public static class TripleTrouble
    {
        public static string TripleTrouble8(string one, string two, string three)
        {
            string newString = "";
            for (int i = 0; i < one.Length; i++)
            {
                newString += one[i];
                newString += two[i];
                newString += three[i];
            }

            return newString;
        }

        //Triple Trouble
        //Create a function that will return a string that combines all of the letters 
        //    of the three inputed strings in groups.Taking the first letter of all of 
        //    the inputs and grouping them next to each other.Do this for every letter, 
        //    see example below!

        //E.g.Input: "aa", "bb" , "cc" => Output: "abcabc"

        //Note: You can expect all of the inputs to be the same length.
    }
}