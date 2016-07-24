using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var presidents = new LinkedList<string>();
            presidents.AddLast("JFK");
            presidents.AddLast("Lyndon B Johnson");
            presidents.AddLast("Richard Nixon");
            presidents.AddLast("Jimmy Carter");

            DisplayItemsInCollection(presidents);

            // Fix list of presidents
            
            //presidents.Remove("JFK"); // Not very efficient
            presidents.RemoveFirst();
            LinkedListNode<string> kennedy = presidents.AddFirst("John F Kennedy");

            LinkedListNode<string> nixon = presidents.Find("Richard Nixon"); // Not very efficient
            presidents.AddAfter(nixon, "Gerald Ford");

            DisplayItemsInCollection(presidents);
        }

        public static void DisplayItemsInCollection<T>(ICollection<T> collection)
            where T : class
        {
            foreach (var item in collection)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();
        }
    }
}
