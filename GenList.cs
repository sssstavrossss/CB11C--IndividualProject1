using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectPartA
{
    static class GenList<T>
    {

        public static void AddValue(List<T> x, T value)
        {
            x.Add(value);
        }

    }
}
