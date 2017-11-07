using System;
using System.Collections;

namespace DictionaryCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable hashtable = new Hashtable();
            hashtable["0"] = "Zero";
            hashtable["1"] = "One";
            hashtable["2"] = "Two";
            hashtable["3"] = "Three";
            hashtable["4"] = "Four";
            hashtable["5"] = "Five";
            hashtable["6"] = "Six";
            hashtable["7"] = "Seven";
            hashtable["8"] = "Eight";
            hashtable["9"] = "Nine";

            string phoneNumber = "555-327-1201";

            foreach (char c in phoneNumber)
            {
                string num = c.ToString();
                if (hashtable.ContainsKey(num))
                {
                    Console.WriteLine(hashtable[num]);
                }
            }
            Console.ReadKey();
        }
    }
}
