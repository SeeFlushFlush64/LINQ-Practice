using System;
namespace SelectExtensionMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myArray = new int[] { 1, 2, 3, 4, 5 };
            foreach (string element in SelectElements(myArray))
            {
                System.Console.WriteLine(element);
            }
        }
        public static IEnumerable<string> SelectElements(IList<int> myEnumerable)
        {
            if (myEnumerable.Count == 0) System.Console.WriteLine("Enumerable can't be empty");
            return myEnumerable.Select((x, i) => $"{x}. {i}");
        }
    }
}