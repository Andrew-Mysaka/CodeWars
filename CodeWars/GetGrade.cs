namespace CodeWars
{
    public static class GetGrade
    {
        public static char GetGrade8(int s1, int s2, int s3)
        {
            switch ((s1 + s2 + s3) / 3)
            {
                case int n when n >= 0 && n < 60: return 'F';
                case int n when n >= 60 && n < 70: return 'D';
                case int n when n >= 70 && n < 80: return 'C';
                case int n when n >= 80 && n < 90: return 'B';
                case int n when n >= 90 && n <= 100: return 'A';
                default: return 'F';
            }

            //   return m >= 90 ? 'A' : m >= 80 ? 'B' : m >= 70 ? 'C' : m >= 60 ? 'D' : 'F';
        }
        //Grade book
        //Complete the function so that it finds the mean of the three scores passed to it 
        //and returns the letter value associated with that grade.

        //    Numerical Score Letter Grade
        //90 <= score <= 100	'A'
        //80 <= score< 90	'B'
        //70 <= score< 80	'C'
        //60 <= score< 70	'D'
        //0 <= score< 60	'F'
        //Tested values are all between 0 and 100. Theres is no need to check for negative 
        //    values or values greater than 100.
    }
}