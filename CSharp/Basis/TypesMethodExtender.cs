using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basis
{
    public static class TypesMethodExtender
    {
        public static int AddFive(this int i)
        {
            return i + 5;
        }

        public static decimal AddFive(this decimal d)
        {
            return d + 5m;
        }
    }
}
