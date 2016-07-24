using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stacks
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<string> books = new Stack<string>();

            books.Push("Programming WPF");
            books.Push("The Philosophy Book");
            books.Push("Heat and Thermodynamics");

            DisplayItemsInCollection(books);

            Console.WriteLine("Books after popping:");
            Console.WriteLine("Top item is: {0}", books.Peek());

        }

        public static void DisplayItemsInCollection(ICollection collection)
        {
            foreach (var item in collection)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();
        }

    }
}
