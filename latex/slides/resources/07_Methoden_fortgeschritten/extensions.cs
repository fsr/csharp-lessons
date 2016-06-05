public static class StringExt
{
    // Das sind Extension-Methoden.
    public static string SayHelloFromMeTo(this string s, string name)
    {
        return "I'm " + s + ". Hello " + n + "!";
    }
    public static int CountWords(this string s)
    {
        char[] split = new char[] { ' ', , ',', '.', '?' };
        // Der eigene String wird gesplittet und ausgezaehlt
        string[] words = s.Split(split, 
                      StringSplitOptions.RemoveEmptyEntries)
        return words.Length;
    }
}