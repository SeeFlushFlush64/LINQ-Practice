using System;

namespace FindTheShortestStringInAStringArray
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] myArray = new string[] { "dog", "racecar", "car" };
            foreach(string str in GetShortestString(myArray))
            {
                System.Console.WriteLine(str);
            }
        }
        static string[] GetShortestString(string[] myArray)
        {
            
            return myArray.OrderBy(str => str.Length).ThenBy(str => str).ToArray();
        }
    }
}