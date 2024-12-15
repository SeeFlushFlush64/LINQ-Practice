using System;
namespace CheckTheCharsOfEachString
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] myArray = new string[] { "flower", "flow", "flight" };
            System.Console.WriteLine(LongestCommonSubsequence(myArray));
            
        }
        static string LongestCommonSubsequence(string[] myArray)
        {
            int minLength = myArray.Min(str => str.Length);
            string commonSubsequence = "";
            for (int i = 0; i < minLength; i++)
            {
                char currentChar = myArray[0][i];
                
                foreach (string str in myArray)
                {
                    if (str[i] != currentChar)
                    {
                        return commonSubsequence;
                    }
                    // System.Console.WriteLine(str[i]);
                }
                commonSubsequence += currentChar;
            }
            
            return commonSubsequence;
        }
    }
}