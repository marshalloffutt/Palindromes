using System;

namespace Palindromes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Type something to see if it is a palindrome.");

            var input = Console.ReadLine();
            var userInputString = input.ToLower();
            var userInputCharArray = userInputString.ToCharArray();
  
            var justTheLettersPlease = "";
            var reversedLetters = "";

            foreach (char letter in userInputCharArray)
            {
                if (char.IsLetter(letter))
                {
                    justTheLettersPlease += letter;
                }
            }

            reversedLetters = ReverseTheString(justTheLettersPlease);

            if (justTheLettersPlease == reversedLetters)
            {
                Console.WriteLine($"Yes, {input} is a palindrome.");
            }
            else
            {
                Console.WriteLine($"No, {input} is not a palindrome.");
            }

            Console.ReadKey();
        }

        public static string ReverseTheString(string letters)
        {
            char[] charArray = letters.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }
}
