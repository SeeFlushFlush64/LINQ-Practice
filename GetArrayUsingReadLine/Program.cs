using System;
using System.Linq;
namespace GetArrayUsingReadLine
{
    class Program
    {
        static void Main(string[] args)
        {
            // int[] myArray = Convert.ToInt32(Console.ReadLine());
            // foreach (int i in myArray)
            // {
            //     System.Console.WriteLine(i);
            // }
            // 1 2 3 4 5 6 7
            // 1 2 3 4 5 6
            // 1 2 3 7 6 5 4
            // position of the highest element: 3
            // k  = (7 + 1) / 2
            // k = 4


            // k = (6 + 1) / 2
            // k = 3
            // position of the highest element: 3
            // 1 2 3 4 5 6
            // 1 2 3 6 5 4

            string[] myElements = Console.ReadLine().Split(' ').ToArray();
            int[] myArray = myElements.Select(str => Convert.ToInt32(str)).ToArray();
            int[] zigZagArray = new int[myArray.Length];
            Array.Sort(myArray);
            int n = myArray.Length;
            int k = (myArray.Length + 1) / 2;
            zigZagArray[0] = myArray.Min();
            if (myArray.Length % 2 == 0)
            {
                zigZagArray[k] = myArray.Max();
                for (int i = 1; i < k; i++)
                {
                    zigZagArray[i] = myArray[i];
                }
                for (int i = n - 2, j = k + 1; i >= k; i--, j++)
                {
                    zigZagArray[j] = myArray[i];
                }
            }
            else if (myArray.Length % 2 != 0)
            {
                zigZagArray[k - 1] = myArray.Max();
                for (int i = 1; i < k - 1; i++)
                {
                    zigZagArray[i] = myArray[i];
                }
                for (int i = n - 2, j = k; i >= k - 1; i--, j++)
                {
                    zigZagArray[j] = myArray[i];
                }
            }
            foreach (int num in zigZagArray)
            {
                System.Console.WriteLine(num);
            }
        }
    }
}