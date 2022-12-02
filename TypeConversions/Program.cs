using System;

namespace TypeConversions
{
    class Program
    {
        static void Main(string[] args)
        {
            short shortResult, shortVal = 4;

            int integerVal = 67;

            long longResult;

            float floatVal = 10.5F;

            double doubleResult, doubleVal = 99.999;

            string stringResult, stringVal = "17";

            bool boolVal = true;

            Console.WriteLine("Variable Conversion Examples\n");

            double result = floatVal * shortVal;
            Console.WriteLine($"Implicit, --> double: {floatVal} * {shortVal} = { result }");

            shortResult = (short)floatVal;
            Console.WriteLine($"Explicit, --> short: {floatVal} --> {shortResult}");

            stringResult = Convert.ToString(boolVal) + Convert.ToString(doubleVal);
            Console.WriteLine($"Explicit --> string: \"{boolVal}\" + \"{doubleVal}\" --> " +
                              $"{stringResult}"
            );

            longResult = integerVal + Convert.ToInt64(stringVal);
            Console.WriteLine($"Mixed, --> long: {integerVal} + {stringVal} --> {longResult}");

            Console.ReadKey();

        }
    }
}
