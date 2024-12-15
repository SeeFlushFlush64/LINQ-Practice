using System;
using System.Linq;
namespace PaggawaNgRange
{
    class Program
    {
        static void Main(string[] args)
        {
            // string myDecipheredText = "There's-a-starman-waiting-in-the-sky";
            string myDecipheredText = "159357lcfd";
            // foreach(char c in )
            // {
                
            //     System.Console.WriteLine(c);
            // }
            System.Console.WriteLine(GenerateRange(myDecipheredText, 98));
            
        }
        static string GenerateRange(string decipheredText, int rotation)
        {
            string myAlphabets = string.Join("", Enumerable.Range('a', 26).Select(num => (char)num)) + string.Join("", Enumerable.Range('A', 26).Select(num => (char)num));
            int totalAlphabets = 26;
            string cipheredText = "";
            for (int i = 0; i < decipheredText.Length; i++)
            {
                int position = myAlphabets.IndexOf(decipheredText[i]);
                char cipheredChar = ' ';
                if (char.IsPunctuation(decipheredText[i]) || char.IsDigit(decipheredText[i]))
                {
                    cipheredChar = decipheredText[i];
                }
                else
                {
                    cipheredChar = myAlphabets.ElementAt((position + rotation) % totalAlphabets);
                    cipheredChar = char.IsUpper(decipheredText[i]) ? char.ToUpper(cipheredChar) : cipheredChar;
                }
                cipheredText += cipheredChar;
            }
            return cipheredText;
        }
    }
}