using System;
using System.Collections.Generic;
using System.Linq;

namespace T05._Remove_Negatives_and_Reverse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            List<int> result = numbers.FindAll(x => x >= 0);

            if (result.Count == 0)
            {
                Console.WriteLine("empty");
            }
            else
            {
                result.Reverse();

                Console.WriteLine(string.Join(" ", result));
            }
        }
    }
}
