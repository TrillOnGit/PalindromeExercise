using System;
using System.Linq;

namespace PalindromeExercise;

public class WordSmith
{
    public static bool IsPalindrome(string palWord)
    {
        string palLetters = new string (palWord
            .Where(x => char.IsLetter(x) || char.IsDigit(x))
            .Select(char.ToLower)
            .ToArray());
            
        for (int i = 0; i < palLetters.Length / 2 + 1; i++)
        {
            if (palLetters[i] != palLetters[palLetters.Length - i - 1])
            {
                return false;
            }
        }
        return true;
    }
}