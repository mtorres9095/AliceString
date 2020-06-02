using System;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;

namespace AliceString
{
    class Program
    {
        static void Main(string[] args)
        {
            string alice;
            string input;
            // string portionOfTheSentence;
            int portion;
            int strLength;

            alice = "Alice was beginning to get very tired of sitting by her sister on the bank, and of having nothing to do: once or twice she had peeped into the book her sister was reading, but it had no pictures or conversations in it, and what is the use of a book, thought Alice without pictures or conversation?";
            alice = alice.ToLower();
            Console.WriteLine("Enter a portion of Alice's in Wonderland sentence:");
            input = Console.ReadLine();
            strLength = input.Length;
            portion = alice.IndexOf(input);
            // Console.WriteLine("the number is:"+portion);
            // Exercise #1 Para 2.5.4 Strings Part II
            string result = string.Empty;
            if (portion >= 0)
            {
                result = alice.Remove(portion, input.Length);
            }
             Console.WriteLine("The old phase----->"+ alice);
             Console.WriteLine(" ");
             Console.WriteLine("The new phase----->" + result);
            /* if (portion >= 0) - Eexercise #1 Para 2.5.4 Strings Part I
            {
                Console.WriteLine("The value entered was found!");
            }
            else
            {
                Console.WriteLine("The value entered was NOT found! Try later... ");
            } */



        }
    }
}
