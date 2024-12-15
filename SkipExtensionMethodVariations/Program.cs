using System;
using System.Linq;
namespace SkipExtensionMethodVariations
{
    class Program
    {
        static void Main(string[] args)
        {
            // int[] myArray = new int[] { 1, 2, 3, 4 };
            int [] myArray = new int[0];
            
            foreach (int number in SkipElements(3, myArray)) 
            {
                Console.WriteLine(number);
            }
        }
        static IEnumerable<int> SkipElements(int count, IEnumerable<int> myEnumerable)
        {
            if (count < 0) 
            {
                throw new ArgumentOutOfRangeException(nameof(count), "Count cannot be negative");

            }
            else if (myEnumerable.Count.Equals(0))
            {
                throw new ArgumentNullException(nameof(myEnumerable), "The enumerable cannot be null");
            }
            else if (count.Equals(0))
            {
                return myEnumerable;
            }
            return myEnumerable.Skip(count);
        }
    }
}