using System;
using System.Globalization;

namespace Enums
{   
    /** Defines an enum type called orientation with underlying type int (default) */
    enum orientation
    {
        north = 1,
        south = 2,
        east = 3,
        west = 4
    }

    struct route
    {
        public orientation direction;
        public double distance;
    }

    class Program
    {
        static void Main(string[] args)
        {
            /*orientation myDirection = orientation.north;
            Console.WriteLine($"myDirection = {myDirection}");
            Console.ReadKey();*/

            //byte directionByte;
            //string directionString;
            //orientation myDirection = orientation.north;
            //Console.WriteLine($"myDirection = {myDirection}");

            /** Converts the enum 'orientation' type to its underlying-type of 'byte' */
            //directionByte = (byte)myDirection; // CAUTION: not all byte-type vars map to orientation values

            /** Converts the enum 'orientation' to a string */
            //directionString = Convert.ToString(myDirection); // alternative: directionString.ToString();

            //Console.WriteLine($"byte equivalent = {directionByte}");
            //Console.WriteLine($"string equivalent = {directionString}");
            //Console.ReadKey();


            // create a route struct
            route myRoute;
            // set myDirection to an impossible number (doesn't exist in enum)
            int myDirection = -1;

            double myDistance;

            // Prints the options for user input to console
            Console.WriteLine("1) North\n2) South\n3) East\n4) West");
            
            // Keep prompting user to put in a valid direction
            do
            {
                Console.WriteLine("Select a direction:");
                // Convert the user input to an integer
                myDirection = Convert.ToInt32(Console.ReadLine());
            } while ((myDirection < 1) || (myDirection > 4));

            Console.WriteLine("Input a distance:");
            // How to get user input and convert to an integer
            myDistance = Convert.ToDouble(Console.ReadLine());

            // Cast the user's integer to an orientation enum-val and put it in the struct
            myRoute.direction = (orientation)myDirection;
            myRoute.distance = myDistance;

            Console.WriteLine($"myRoute specifies a direction of {myRoute.direction} " +
                              $"and a distance of {myRoute.distance}");
            Console.ReadKey();
        }
    }
}