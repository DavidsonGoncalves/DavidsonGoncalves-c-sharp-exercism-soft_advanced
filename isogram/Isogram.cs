using System;
using System.Collections.Generic;

public static class Isogram
{
    public static bool IsIsogram(string word)
    {
         if (word.Trim().Length == 0) return true;
        List<string> letters = new List<string>();
        foreach (var c in word)
        {
            string lower = c.ToString().ToLower();

            if (letters.Contains(lower) && lower != "-" && lower.Trim().Length != 0)
                return false;
            letters.Add(lower);
        }
        return true;
    }
}
