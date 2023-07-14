using System;
using System.Linq;

namespace PalindromeExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            IsPalindrome("ab !a");
        }

        public static bool IsPalindrome(string palWord)
        {
            string palLetters = new string (palWord
                .Where(ch => char.IsLetter(ch))
                .Select(x => char.ToLower(x)).ToArray());
            
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
}
