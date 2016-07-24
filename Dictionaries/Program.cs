using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionaries
{
    class Program
    {
        static void Main(string[] args)
        {
            // Lists

            var primeMinisters = new List<PrimeMinister>
            {
                new PrimeMinister("James Callaghan", 1976),
                new PrimeMinister("Margaret Thatcher", 1979),
                new PrimeMinister("Tony Blair", 1997)
            };

            foreach (var minister in primeMinisters)
            {
                Console.WriteLine(minister.ToString());
            }

            // Dictionaries

            var primeMinistersDictionary = new Dictionary<string, PrimeMinister>
            {
                {"JC", new PrimeMinister("James Callaghan", 1976) },
                {"MT", new PrimeMinister("Margaret Thatcher", 1979) },
                {"TB", new PrimeMinister("Tony Blair", 1997) }
            };

            foreach (var pm in primeMinistersDictionary)
            {
                Console.WriteLine(pm.Key + " " + pm.Value);
            }

            PrimeMinister primeMinister;
            var found = primeMinistersDictionary.TryGetValue("MT", out primeMinister);
            
            if (found)
            {
                Console.WriteLine("Prime minister: {0} found", primeMinister.Name);
            }
            else
            {
                Console.WriteLine("Prime minister not found found");
            }

            
            // ReadOnlyDictionary created from the last Dictionary used

            var pmsReadOnly = new ReadOnlyDictionary<string, PrimeMinister>(primeMinistersDictionary);

            // SortedList

            var sortedPMsList = new SortedList<string, PrimeMinister>(new UncasedStringComparer())
            {
                {"JC", new PrimeMinister("James Callaghan", 1976) },
                {"MT", new PrimeMinister("Margaret Thatcher", 1979) },
                {"TB", new PrimeMinister("Tony Blair", 1997) }
            };

            Console.WriteLine(sortedPMsList["tb"]);

            // SortedDictionary
            // Uses balancedtree compared to SortedList

            var sortedPMsDictionary = new SortedDictionary<string, PrimeMinister>(new UncasedStringComparer())
            {
                {"JC", new PrimeMinister("James Callaghan", 1976) },
                {"MT", new PrimeMinister("Margaret Thatcher", 1979) },
                {"TB", new PrimeMinister("Tony Blair", 1997) }
            };

            Console.WriteLine(sortedPMsDictionary["tb"]);

            // KeyedCollection - extract keys from values

            var keyedPMsDictionary = new PrimeMinisterKeyedCollection()
            {
                new PrimeMinister("James Callaghan", 1976),
                new PrimeMinister("Margaret Thatcher", 1979),
                new PrimeMinister("Tony Blair", 1997)
            };

            Console.WriteLine(keyedPMsDictionary[1976]);

            // Cast to IList to look up by index, not by key
            var listKeyedPMs = keyedPMsDictionary as IList<PrimeMinister>;

            Console.WriteLine("The first item is: {0}", listKeyedPMs[0]);
        }
    }

    class PrimeMinisterKeyedCollection : KeyedCollection<int, PrimeMinister>
    {
        protected override int GetKeyForItem(PrimeMinister item)
        {
            return item.YearElected;
        }

    }
}
