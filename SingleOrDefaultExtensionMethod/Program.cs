using System;
using System.Linq;
namespace SingleOrDefaultExtensionMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myArray = new int[] { };
            System.Console.WriteLine(myArray.SingleOrDefault());
        }
    }
}