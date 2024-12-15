using System;
using System.Linq;
namespace LastOrDefaultExtensionMethod
{
    //imbes na magthrow ng System.InvalidOperationException, Sequence contains no elements, nagrereturn siya ng 0
    //irereturn niya yung nag-iisang element sa collection
    //basta ano lang, dapat may laman siya element kung ayaw mo na magreturn siya ng default value
    class Program
    {
        static void Main(string[] args)
        {
            int[] myArray = new int[] { };
            System.Console.WriteLine(myArray.LastOrDefault());
            
        }
    }
}