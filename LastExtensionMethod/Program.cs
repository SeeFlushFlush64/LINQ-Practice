using System;
using System.Linq;
namespace LastExtensionMethod
{
    //throws System.InvalidOperationException, Sequence contains no elements
    //irereturn niya yung nag-iisang element sa collection
    //
    class Program
    {
        static void Main(string[] args)
        {
            int[] myArray = new int[] { 1, 2 };
            System.Console.WriteLine(myArray.Last());
            
        }
    }
}