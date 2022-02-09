using System;
using System.Collections.Generic;

namespace T04._List_of_Products
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int products = int.Parse(Console.ReadLine());

            List<string> productsList = new List<string>();

            for (int i = 0; i < products; i++)
            {
                productsList.Add(Console.ReadLine());
            }

            productsList.Sort();

            for (int i = 0; i < products; i++)
            {
                Console.WriteLine($"{i + 1}.{productsList[i]}");
            }
        }
    }
}
