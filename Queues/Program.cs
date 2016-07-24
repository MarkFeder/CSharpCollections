using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queues
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<string> tasks = new Queue<string>();

            tasks.Enqueue("Do the washing up!");
            tasks.Enqueue("Finish the C# Collections course");
            tasks.Enqueue("Buy some chocolate");

            Console.WriteLine("\nALL TASKS:");
            foreach (var title in tasks)
            {
                Console.WriteLine(title);
            }

            Console.WriteLine("Next item to do: {0}", tasks.Dequeue());
        }
    }
}
