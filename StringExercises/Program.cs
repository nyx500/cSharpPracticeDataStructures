using System;
using System.Text;

namespace StringExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Write a console application that accepts a string from the user and outputs a string with
            the characters in reverse order.*/

            string input;

            Console.WriteLine("Please input a string: ");
            input = Console.ReadLine();

            char[] inputChars = new char[input.Length];

            for (int i = 0; i < input.Length; i++)
            {
                inputChars[i] = input[input.Length - 1 - i];
            }

            foreach (char c in inputChars)
            {
                Console.Write(c);
            }

            // Official answer - USING CONCATENATION (+)
            // Console.WriteLine("Enter a string:");
            // string myString = ReadLine();
            // string reversedString = "";
            //for (int index = myString.Length - 1; index >= 0; index--)
            //{
                //reversedString += myString[index];
            //}
            //WriteLine($"Reversed: {reversedString}")


            /*Write a console application that accepts a string and replaces all occurrences of the
            string no with yes.*/
            // OFFICIAL ANSWER: also uses "Replace" string method
            string noToYesString;
            Console.WriteLine("\nPlease enter a string containing the word 'no':");
            noToYesString = Console.ReadLine();
            noToYesString = noToYesString.Replace("no", "yes");
            Console.WriteLine("Changed string: " + noToYesString);


            /*Write a console application that places double quotes around each word in a string*/

            string another_input;
            Console.WriteLine("\nPlease enter another string:");
            another_input = Console.ReadLine();
            string[] another_input_string_array = another_input.Split(' ');


            var result = new StringBuilder();

            for (int i = 0; i < another_input_string_array.Length; i++)
            {
                string s;
                s = $" \"{another_input_string_array[i]}\" ";
                result.Append(s);
            }

            string stringResult = result.ToString();

            Console.WriteLine(stringResult);


            Console.ReadKey();
        }
    }
}