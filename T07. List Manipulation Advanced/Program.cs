using System;
using System.Collections.Generic;
using System.Linq;

namespace T07._List_Manipulation_Advanced
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> listOfNums = Console.ReadLine().Split().Select(int.Parse).ToList();

            string command = Console.ReadLine();

            bool isChanged = false;

            while (command != "end")
            {
                string[] arrayArgs = command.Split();

                string action = arrayArgs[0];

                if (action == "Add")
                {
                    int numberToAdd = int.Parse(arrayArgs[1]);
                    listOfNums.Add(numberToAdd);
                    isChanged = true;
                }
                else if (action == "Remove")
                {
                    int numberToRemove = int.Parse(arrayArgs[1]);
                    listOfNums.Remove(numberToRemove);
                    isChanged = true;
                }
                else if (action == "RemoveAt")
                {
                    int indexToRemove = int.Parse(arrayArgs[1]);
                    listOfNums.RemoveAt(indexToRemove);
                    isChanged = true;
                }
                else if (action == "Insert")
                {
                    int index = int.Parse(arrayArgs[2]);
                    int item = int.Parse(arrayArgs[1]);
                    listOfNums.Insert(index, item);
                    isChanged = true;
                }
                else if (action == "Contains")
                {
                    int checkingNumber = int.Parse(arrayArgs[1]);

                    if (listOfNums.Contains(checkingNumber))
                    {
                        Console.WriteLine("Yes");
                    }
                    else
                    {
                        Console.WriteLine("No such number");
                    }
                }
                else if (action == "PrintEven")
                {
                    List<int> evenNumbers = listOfNums.FindAll(x => x % 2 == 0);
                    Console.WriteLine(string.Join(" ", evenNumbers));
                }
                else if (action == "PrintOdd")
                {
                    List<int> oddNumbers = listOfNums.FindAll(x => x % 2 != 0);
                    Console.WriteLine(string.Join(" ", oddNumbers));
                }
                else if (action == "GetSum")
                {
                    Console.WriteLine(listOfNums.Sum());
                }
                else if (action == "Filter")
                {
                    string comparisionSign = arrayArgs[1];
                    int numberToCompare = int.Parse(arrayArgs[2]);

                    // TODO: Finish the code
                    List<int> satisfyingNumbers = GetFilteredNumbers(listOfNums, comparisionSign, numberToCompare);
                    Console.WriteLine(string.Join(" ", satisfyingNumbers));
                }

                command = Console.ReadLine();
            }

            if (isChanged)
            {
                Console.WriteLine(string.Join(" ", listOfNums));
            }
        }

        static List<int> GetFilteredNumbers(List<int> numbers ,string condition, int numberToCompare)
        {
            // '<', '>', ">=", "<="
            
            if (condition == "<")
            {
                return numbers.FindAll(x => x < numberToCompare);
            }
            else if (condition == ">")
            {
                return numbers.FindAll(x => x > numberToCompare);
            }
            else if (condition == ">=")
            {
                return numbers.FindAll(x => x >= numberToCompare);
            }
            else if (condition == "<=")
            {
                return numbers.FindAll(x => x <= numberToCompare);
            }
            else
            {
                return numbers;
            }
        }
    }
}
