using System;
using System.Collections.Generic;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int[] numArray = {0,1,2,3,4,5,6,7,8,9};
            string[] nameArray = {"Tim", "Martin", "Nikki", "Sara"};
            bool[] booleanArray = {true, false, true, false, true, false, true, false, true, false};
            
            List<string> flavors = new List<string>();
            flavors.Add("Strawberry");
            flavors.Add("Chocolate");
            flavors.Add("Blueberry");
            flavors.Add("Vanilla");
            flavors.Add("Pistachio");
            Console.WriteLine("The length of this list is {0}", flavors.Count);
            Console.WriteLine(flavors[2]);
            flavors.RemoveAt(2);
            Console.WriteLine("The new length of the list is " + flavors.Count);
            int count = flavors.Count;
            
            Random rand = new Random();
            Dictionary<string,string> user = new Dictionary<string, string>();
            user.Add(nameArray[0], flavors[rand.Next(count)]);
            user.Add(nameArray[1], flavors[rand.Next(count)]);
            user.Add(nameArray[2], flavors[rand.Next(count)]);
            user.Add(nameArray[3], flavors[rand.Next(count)]);

            foreach (KeyValuePair<string,string>entry in user)
            {
                System.Console.WriteLine(entry.Key + ":" + entry.Value);
            }

        }
    }
}
