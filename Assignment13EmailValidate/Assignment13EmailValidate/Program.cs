// See https://aka.ms/new-console-template for more information

using System;
using System.Text.RegularExpressions;
namespace Assignment13EmailValidate
{
    internal class Program
    {
        static void Main(string[]args)
        {
            // Step 3: Prompt user for input
            Console.WriteLine("Enter a piece of text:");
            string inputText = Console.ReadLine();

            // Step 4: Call implemented methods and display results
            int wordCount = CountWords(inputText);
            Console.WriteLine($"Word Count: {wordCount}");

            ValidateEmailAddresses(inputText);

            ExtractMobileNumbers(inputText);

            // Step 5: Allow user to input a custom regex
            Console.WriteLine("Enter a custom regex pattern:");
            string customRegexPattern = Console.ReadLine();
            CustomRegexSearch(inputText, customRegexPattern);

            Console.ReadLine(); 
        }

        // Step 2: Implement methods
        static int CountWords(string text)
        {
            string[] words = text.Split(' ');
            return words.Length;
        }

        static void ValidateEmailAddresses(string text)
        {
            Regex emailRegex = new Regex(@"\b[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Z|a-z]{2,}\b");

            MatchCollection matches = emailRegex.Matches(text);

            Console.WriteLine("Email Addresses found:");

            foreach (Match match in matches)
            {
                Console.WriteLine(match.Value);
            }
        }

        static void ExtractMobileNumbers(string text)
        {
            Regex mobileRegex = new Regex(@"\b\d{10}\b");

            MatchCollection matches = mobileRegex.Matches(text);

            Console.WriteLine("Mobile Numbers found:");

            foreach (Match match in matches)
            {
                Console.WriteLine(match.Value);
            }
        }

        static void CustomRegexSearch(string text, string pattern)
        {
            Regex customRegex = new Regex(pattern);

            MatchCollection matches = customRegex.Matches(text);

            Console.WriteLine("Custom Regex Search Results:");

            foreach (Match match in matches)
            {
                Console.WriteLine(match.Value);
            }
        }
    }
}
