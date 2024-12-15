using System;
namespace RemoveAChar
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "Michael";
            System.Console.WriteLine(RemoveChar(str));
            
        }
        static string RemoveChar(string str)
        {
            string newStr = str.Replace(str[0], '');
            return newStr;
        }
    }
}