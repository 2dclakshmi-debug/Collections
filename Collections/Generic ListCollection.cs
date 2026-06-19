using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    internal class Class1
    {
            static void Main(string[] args)
            {
                List<string> names = new List<string>();
                names.Add("Ramu");
                names.Add("Ravi");
                names.Add("Raju");
                names.Add("Raghu");
                names.Add("Rani");
                Console.WriteLine("names in list: ");
                foreach (string i in names)
                {
                    Console.WriteLine(i);
                }
                names.Remove("Raju");
                Console.WriteLine("After Removing names in list: ");
                foreach (string i in names)
                {
                    Console.WriteLine(i);
                }
                names.Sort();
                Console.WriteLine(" After Sorting names in list: ");
                foreach (string i in names)
                {
                    Console.WriteLine(i);
                }
                names.Reverse();
                Console.WriteLine(" After REversing names in list: ");
                foreach (string i in names)
                {
                    Console.WriteLine(i);
                }
                Console.WriteLine("Count of names: " + names.Count);
                names.Clear();
                Console.WriteLine("Count of names after clearing: " + names.Count);


            }
        }
    }







}
}
