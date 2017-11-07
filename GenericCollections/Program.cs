using System;
using System.Collections.Generic;

namespace GenericCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> dictionary = new Dictionary<int, string>();

            dictionary[39] = "Italy";
            dictionary[36] = "Hungary";
            dictionary[81] = "Japan";
            dictionary[688] = "Tuvalu";

            Console.WriteLine($"The 39 code is for {dictionary[39]}");

            foreach (int key in dictionary.Keys)
            {
                Console.WriteLine($"The {key} code is for {dictionary[key]}.");
            }

            Console.ReadKey();
        }
    }
}
