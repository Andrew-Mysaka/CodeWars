namespace CodeWars
{
    public static class IsUpperCase
    {
        public static bool IsUpperCase8(this string text)
        {
            return (text.ToUpper() == text);
        }
    }
}