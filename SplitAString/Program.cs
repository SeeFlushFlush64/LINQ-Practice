using System;
using System.Linq;
namespace SplitAString
{
    class Program
    {
        static void Main(string[] args)
        {
            string number = "123";
            char[] digits = number.ToCharArray();
            int[] digitConverted = digits.Select(c => (int)char.GetNumericValue(c)).ToArray();
            int sum = 0;
            foreach (int digit in digitConverted)
            {
                System.Console.WriteLine(digit);
                sum += digit;
            }
            Console.WriteLine(sum);
        }
    }
}