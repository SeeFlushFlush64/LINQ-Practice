using System;
using System.Linq;
namespace WhereExtensionMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myNumbers = new int[] { 1, 2, 3, 4 };

            System.Console.Write("These are the even numbers: ");
            foreach (int n in GetEvenNumbers(myNumbers))
            {
                Console.Write("{0} ", n);
            }

            System.Console.WriteLine();
            
            System.Console.Write("These are the odd numbers: ");
            foreach (int n in GetOddNumbers(myNumbers))
            {
                Console.Write("{0} ", n);
            }
        }
        public static IEnumerable<int> GetEvenNumbers(int[] numbers)
        {
            return numbers.Where(n => n % 2 == 0);
        }
        public static IEnumerable<int> GetOddNumbers(int[] numbers)
        {
            return numbers.Where(n => n % 2 != 0);
        }
    }
}