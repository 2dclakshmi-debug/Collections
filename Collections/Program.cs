using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    internal class Program
        {
            static void Main(string[] args)
            {
                ArrayList list = new ArrayList();
                list.Add("Ramesh");
                list.Add("Ganesh");
                list.Add("Hareesh");
                Console.WriteLine("ArrayList Elements are");
                foreach (var items in list)
                {
                    Console.WriteLine(items);
                }
                Hashtable ht = new Hashtable();
                ht.Add("1", "Ramesh");
                ht.Add("2", "Ganesh");
                ht.Add("3", "Hareesh");
                Console.WriteLine("HashTable Elements are");
                foreach (DictionaryEntry entry in ht)
                {
                    Console.WriteLine("key {0}  value {1}", entry.Key, entry.Value);
                }
                Queue queue = new Queue();
                queue.Enqueue("Ramesh");
                queue.Enqueue("Ganesh");
                queue.Enqueue("Hareesh");
                Console.WriteLine("queue students  :");
                foreach (var item in queue)
                {
                    Console.WriteLine(item);
                }
                Console.WriteLine("Dequeue one student :" + queue.Dequeue());
                foreach (var item in queue)
                {
                    Console.WriteLine(item);
                }
                Stack stack = new Stack();
                stack.Push("ASP");
                stack.Push("Ado");
                stack.Push("MVC");
                Console.WriteLine(" Stack books:");
                foreach (var item in stack)
                {
                    Console.WriteLine(item);
                }
                Console.WriteLine(" Pop one book:" + stack.Pop());
                foreach (var item in stack)
                {
                    Console.WriteLine(item);
                }

            }
        
    }
}
    

