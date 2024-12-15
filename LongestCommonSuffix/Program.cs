using System;
namespace LongestCommonSuffix
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] myArray = new string[] { "" };
            LongestSuffix(myArray);
        }
        static string LongestSuffix(string[] myArray)
        {
            string commonSuffix = "";
            int minLength = myArray.Min(str => str.Length);
            for (int i = minLength; i > 0; i++)
            {
                char currentChar = myArray[0][i];
                foreach (string str in myArray)
            }
            return commonSuffix;
        }
    }
}