using System;
namespace GettingSumInsideNestedArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] myArray = new int[][] { [ 1, 2, 3, 4 ], [ 5, 6, 7 ] };
            // foreach (int num in GetArrayInsideArray(myArray))
            // {
            //     System.Console.WriteLine(num);
            // }
            // System.Console.WriteLine(GetSumOfAnArray(myArray));
            foreach(int num in GetSumOfEachArray(myArray))
            {
                System.Console.WriteLine(num);
            }
        }
        static int[] GetArrayInsideArray(int[][] myArray)
        {
            return myArray.FirstOrDefault();
        }
        static int GetSumOfAnArray(int[][] myArray)
        {
            return myArray.FirstOrDefault().Sum(asset => asset);
        }
        static int[] GetSumOfEachArray(int[][] myArray)
        {
            return myArray.Select(array => array.Min()).ToArray();
        }
    }
}