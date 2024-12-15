//OfType<datatype>() linq extension method could be used to filter numbers in an IEnumerable<object> containing numbers, characters, strings and other types

using System;
namespace OfTypeExtensionMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            IEnumerable<object> values = [1, 2, 3, 4, "Michael", '!'];
            var myStrings = values.OfType<string>();
            var myNumbers = values.OfType<int>();
            
            foreach (string myString in myStrings)
            {
                Console.WriteLine(myString);
            }
            foreach (int number in myNumbers)
            {
                Console.WriteLine(number);
            }

        }
    }
}