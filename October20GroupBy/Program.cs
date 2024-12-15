using System;
namespace October20GroupBy
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> myNumbers = [1, 2, 3, 4, 3, 2, 1];

            // var groups = myNumbers.GroupBy(x => x % 2 == 1 ? "Odd" : "Even");
            Dictionary<int, int> keyValuePairs = new Dictionary<int, int>();
            int indexValue = 0;
            foreach (var number in myNumbers)
            {
                if (keyValuePairs.ContainsKey(number))
                {
                    keyValuePairs.Remove(number);
                    indexValue--;
                }
                else 
                {
                    keyValuePairs.Add(number, indexValue);
                    indexValue++; 
                }
            }
            List<int> uniqueNums = keyValuePairs.Keys.ToList();
            System.Console.WriteLine(uniqueNums.Count);
            foreach (int number in uniqueNums)
            {
                System.Console.WriteLine(number);
            }

        
            // foreach (var group in groups)
            // {
            //     System.Console.WriteLine(group.Key);
            //     foreach (var num in group)
            //     {
            //         System.Console.WriteLine(num);
            //     }
            // }

        }
    }
}