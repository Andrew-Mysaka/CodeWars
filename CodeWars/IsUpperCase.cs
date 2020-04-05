namespace CodeWars
{
    public static class IsUpperCase
    {
        public static bool IsUpperCase8(this string text)
        {
            return (text.ToUpper() == text);
        }

        //In this Kata, a string is said to be in ALL CAPS whenever it 
        //does not contain any lowercase letter so any string containing 
        //no letters at all is trivially considered to be in ALL CAPS.
    }
}