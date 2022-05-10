using System;

namespace CS162NMidterm2
{
    class Program
    {
        static void Main(string[] args)
        {
            static void Main(string[] args)
            {
                Console.WriteLine("Checks if your input is a palindrome.");
                Console.Write("Please enter a string: ");
                string userInput = Console.ReadLine();
                string s = CleanUpString(userInput);
                if (IsPalindrome(s))
                    Console.WriteLine("That's a palindrome!");
                else
                    Console.WriteLine("That isn't a palindrome.");

            }

            static string CleanUpString(string s)
            {
                char[] punctuation = { '.', '\'', ',', '.', '!', '?', ' ' };
                foreach (char c in punctuation)
                    while (s.Contains(c))
                        s = s.Substring(0, s.IndexOf(c)) + s.Substring(s.IndexOf(c) + 1);

                return s.ToLower();
            }

            static bool IsPalindrome(string s)
            {
                if (s.Length <= 1)
                    return true;
                else if (s[0] == s[s.Length - 1] && IsPalindrome(s.Substring(1, s.Length - 2)))
                    return true;
                return false;
            }
        }
    }
}