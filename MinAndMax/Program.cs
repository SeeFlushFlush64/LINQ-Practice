using System;
using System.Collections.Generic;
namespace MinAndMax
{
    class Program
    {
        static void Main(string[] args)
        {
            // int[] myArray = new int[] { 12, 240, 300 };
            string[] myArray = new string[] { "dog", "racecar", "car"};
            System.Console.WriteLine(MinLength(myArray).Length);
            
        }
        static T MinLength<T>(T[] myArray)
        {
            return myArray.Min();
        }
    }
}