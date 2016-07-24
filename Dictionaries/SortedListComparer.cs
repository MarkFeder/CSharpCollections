using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionaries
{
    class UncasedStringComparer : IComparer<string>
    {
        public int Compare(string x, string y)
        {
            // Always returns 0, 1 or -1 as a good pattern
            return string.Compare(x, y, StringComparison.InvariantCultureIgnoreCase);
        }
    }
}
