using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionaries
{
    class DictionaryComparer : IEqualityComparer<PrimeMinister>
    {
        public bool Equals(PrimeMinister x, PrimeMinister y)
        {
            return x.Name.ToUpper() == y.Name.ToUpper();
        }

        public int GetHashCode(PrimeMinister obj)
        {
            // Custom HashCode to return same objects
            return obj.Name.ToUpper().GetHashCode();
        }
    }
}
