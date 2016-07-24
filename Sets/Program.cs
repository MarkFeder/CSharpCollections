using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sets
{
    class Program
    {
        static void Main(string[] args)
        {
            var bigCities = new HashSet<string>()
            {
                "New York","Manchester", "Madrid", "Barcelona"
            };

            bigCities.Add("Beijing");
            var added = bigCities.Add("Beijing"); // Do it twice

            Console.WriteLine("Was Beijing added twice in bigCities?: {0} \n", added);

            // Using custom IEqualityComparer<T>

            var bigCitiesWithComparer = new HashSet<string>(new UnCasedStringEqualityComparer())
            {
                "New York","Manchester", "Madrid", "Barcelona"
            };

            bigCitiesWithComparer.Add("Beijing");
            added = bigCitiesWithComparer.Add("Beijing"); // Do it twice

            Console.WriteLine("Was Beijing added twice in bigCitiesWithComparer?: {0} \n", added);

            // Intersaction operation for HashSet

            string[] citiesInUK = { "Sheffield", "Ripon", "Truro", "Manchester" };

            bigCities.IntersectWith(citiesInUK);

            // Other method to use: LINQ method, which creates a new Collection and works for any collection
            // var newCities = bigCities.Intersect(citiesInUk)

            Console.WriteLine("bigCities collection status once we have the intersection done: ");
            foreach (string city in bigCities)
            {
                Console.WriteLine(city);
            }
        }
    }
}
