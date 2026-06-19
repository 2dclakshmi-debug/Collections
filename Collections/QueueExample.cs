using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    internal class QueueExample
    {
            static void Main(string[] args)
            {
                Queue<string> names = new Queue<string>();
                names.Enqueue("Ravi");
                names.Enqueue("Rani");
                names.Enqueue("Radha");
                names.Enqueue("Raji");
                Console.WriteLine("Queue elements are :");
                foreach (var i in names)
                {
                    Console.WriteLine(i);
                }
                Console.WriteLine("remove element :" + names.Dequeue());
                foreach (var i in names)
                {
                    Console.WriteLine(i);
                }
                Console.WriteLine("return element :" + names.Peek());
                foreach (var i in names)
                {
                    Console.WriteLine(i);
                }
                Console.WriteLine("number of names: " + names.Count);
                Console.WriteLine("Contains Radha :" + names.Contains("Radha"));
                names.Clear();
                Console.WriteLine("number of names after clear: " + names.Count);


            }
        }
    }







}
}
