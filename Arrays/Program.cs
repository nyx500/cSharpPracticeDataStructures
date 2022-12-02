using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] friendsNames = { "Jane Smith", "Mary Baker", "Audrey Ford" };
            Console.WriteLine($"Here are {friendsNames.Length} names of my friends:");

            foreach (string friendName in friendsNames)
            {
                switch (friendName)
                {   
                    // Checks if friendName is a string and assigns the string to 't'
                    case string j when j.StartsWith("J"):
                        Console.WriteLine("This friend's name starts with 'J'" +
                                          $"{friendName} and is {j.Length - 1} letters long. ");
                        break;
                    // Checks if friendName is a string and assigns the string to 'm'
                    case string m when m.StartsWith("M"):
                        Console.WriteLine("This friend's name starts with 'M'" +
                                          $"{friendName} and is {m.Length - 1} letters long. ");
                        break;
                    // Checks if friendName is a string and assigns the string to 'm'
                    case string a when a.StartsWith("A"):
                        Console.WriteLine("This friend's name starts with 'A'" +
                                          $"{friendName} and is {a.Length - 1} letters long. ");
                        break;
                    // Checks if friendName is an empty string and assigns it to string 'e'
                    case string e when e.Length == 0:
                        Console.WriteLine("There is an empty string in the array.");
                        break;
                    case null:
                        Console.WriteLine("There is a 'null'-value in this array!");
                        break;
                    // Unclear which data type --> use 'var' keyword
                    case var x:
                        Console.WriteLine("This is the var pattern of type: " +
                                          $"{x.GetType().Name}");
                        break;
                    default:
                        break;

                }
            }

            int sum = 0, total = 0, counter = 0, intValue = 0;
            int?[] myIntArray = new int?[7] { 5, intValue, 9, 10, null, 2, 99 };

            foreach (var integer in myIntArray)
            {
                switch (integer)
                {
                    case 0:
                        Console.WriteLine($"Integer number '{counter}' has a default value of 0");
                        break;
                    case int value:
                        sum += value;
                        Console.WriteLine($"Integer number '{counter}' has a value of {value}");
                        break;
                    case null:
                        Console.WriteLine($"Integer number '{counter}' is null.");
                        break;
                    default:
                        break;
                }
                counter++;
            }

            Console.WriteLine($"The sum of all {counter} integers is {sum}");

            Console.ReadLine();
        }
    }
}