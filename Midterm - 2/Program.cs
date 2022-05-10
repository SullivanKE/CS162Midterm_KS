using System;
using System.Collections;

namespace CS162NMidterm2
{
    class Program
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
            char[] chars = s.ToCharArray();
            Queue q = new Queue();
            Stack stack = new Stack();
            foreach (char c in chars)
            {
                q.Enqueue(c);
                stack.Push(c);
            }

            bool palindrome = true;
            while (stack.Count > 0 && palindrome)
            {
                if ((char)q.Dequeue() != (char)stack.Pop())
                    palindrome = false;
            }
            return palindrome;
        }
        
    }
}