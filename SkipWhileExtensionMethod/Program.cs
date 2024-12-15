using System;
namespace SkipWhileExtensionMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myArray = new int[] { 1, 2, 3, 4, 5 };
            foreach (int number in SkipWhileElements(myArray))
            {
                System.Console.WriteLine(number);
            }
        }
        public static IEnumerable<int> SkipWhileElements(IList<int> myList)
        {
            if (myList.Count == 0)
            {
                System.Console.WriteLine("The enumerable can't be null");
            }            
            return myList.SkipWhile(num => num <= 2);
        }
    }
}