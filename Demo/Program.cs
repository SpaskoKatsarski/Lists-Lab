using System;
using System.Collections.Generic;

namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> names = new List<string>(); 

            names.Add("Spasko");
            names.Add("Iliana");
            names.Add("Yordan");

            names.Insert(0, "Mario");

            Console.WriteLine(String.Join(", ", names));

            names.Remove(names[1]);

            Console.WriteLine(String.Join(", ", names));

            List<string> namesTwo = new List<string>()
            {
                "Spasko",
                "George"
            };

            namesTwo.Remove("Stephen");

            Console.WriteLine(String.Join(" ", namesTwo)); 
        }
    }
}
