using System;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {   
            // creates a string called myString as a test
            string myString = "This is a string!";

            // array of chars with one element: the space
            char[] separator = {' '};

            // sets up an empty array of strings called myWords
            string[] myWords;

            // sets myWords string-array to result of calling Split(' ') on our string
            myWords = myString.Split(separator);

            // iterates over the array of strings and prints each string
            foreach (string word in myWords)
            {
                Console.WriteLine($"{word}");
            }

            string[] stringArray = new string[6] {"this", "is", "an", "array", "of", "strings"};

            Console.WriteLine($"This is string at index 5: " + stringArray[5] +"");

            Console.ReadKey();
        }
    }
}