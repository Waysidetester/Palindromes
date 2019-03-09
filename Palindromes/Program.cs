using System;
using System.Collections.Generic;

namespace Palindromes
{
    class Program
    {
        static void Main(string[] args)
        {

            string test1 = "Stars";

            string test2 = "O, a kak Uwakov lil vo kawu kakao!";

            string test3 = "Some men interpret nine memos";

            bool PalinTest(string testString)
            {
                var chars = testString.ToCharArray();
                List<char> updatedChars = new List<char>();
                foreach (char item in chars) {
                    if (Char.IsLetter(item))
                    {
                        updatedChars.Add(item);
                    }
                }
                List<char> newUpdatedChars = new List<char>();
                newUpdatedChars.AddRange(updatedChars);
                newUpdatedChars.Reverse();

                bool finalOutput = true;
                for (int i = 0; i < newUpdatedChars.Count; i++)
                {

                    if (Char.ToLower(newUpdatedChars[i]) != Char.ToLower(updatedChars[i]))
                    {
                        finalOutput = false;
                        break;
                    }
                }

                return finalOutput;
            }
            Console.WriteLine($"{test1} is {(PalinTest(test1) ? "" : "not ")}a palindrome");
            Console.WriteLine($"{test2} is {(PalinTest(test2) ? "" : "not ")}a palindrome");
            Console.WriteLine($"{test3} is {(PalinTest(test3) ? "" : "not ")}a palindrome");
            Console.WriteLine(PalinTest(test3));
            Console.ReadLine();
        }
    }
}
