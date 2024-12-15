using System;
using System.Linq;
namespace SelectManyExtension
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] myArray = new int[][] { 
                new int[] { 1, 2, 3 },
                new int[] { 4, 5, 6 } 
            };

            //This works as expected
            foreach (string num in myArray.SelectMany(num => num).Select(num => num.ToString()))
            {
                System.Console.WriteLine(num);
            }

            //This does not work as expected
            // foreach (string num in myArray.SelectMany(num => num.ToString()))
            // {
            //     System.Console.WriteLine(num);
            // }
            // int sum = 0;
            // foreach(int num in myArray.SelectMany(numArray => numArray).Cast<int>())
            // {
            //     sum += num;
            // }
            // System.Console.WriteLine(sum);

            // System.Console.WriteLine(myArray.SelectMany(numArray => numArray).Max());
            // System.Console.WriteLine(myArray.SelectMany(numArray => numArray).Max(num => num * (-1)));

            var myPeople = new[] {
                new { Name = "Michael", Age = 22 },
                new { Name = "Rhey", Age = 18 }
            };
            var oldestPerson = myPeople.MaxBy(p => p.Age);
            System.Console.WriteLine(oldestPerson.Name);

            
        }
    }
}