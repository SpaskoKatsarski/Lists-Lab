using System;
using System.Collections.Generic;
using System.Linq;

namespace T06._List_Manipulation_Basics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> listOfNums = Console.ReadLine().Split().Select(int.Parse).ToList();

            string command = Console.ReadLine();

            while (command != "end")
            {
                string[] arr = command.Split();

                string action = arr[0];
                int number = int.Parse(arr[1]);

                if (action == "Add")
                {
                    listOfNums.Add(number);
                }
                else if (action == "Remove")
                {
                    listOfNums.Remove(number);
                }
                else if (action == "RemoveAt")
                {
                    listOfNums.RemoveAt(number);
                }
                else if (action == "Insert")
                {
                    int index = int.Parse(arr[2]);
                    listOfNums.Insert(index, number);
                }

                command = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ", listOfNums));
        }
    }
}
