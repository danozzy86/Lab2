using System;
/* 
   Lab 2 - Operations on Strings - Programming 1
   Daniel Osborne Github - danozzy86
   Due 9/14 @ 4PM
*/
namespace Lab2
{
    class Program
    {
        public static void Main()
        {
            Console.WriteLine("Please enter your string so you can learn more about it.");
            string usrInput = Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Your string has {0} vowels.", StringOperators.VowelCount(usrInput));
            Console.WriteLine("Your string has {0} words.", StringOperators.WordCount(usrInput));
            if (StringOperators.IsPalindrome(usrInput))
                Console.WriteLine("Your string is a palindrome.");
            else
                Console.WriteLine("Your string is not a palindrome.");
 
       }
    }
}
