using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poke_Edit
{
    class Bindings<T, T2>
    {
        public T[] SideA;
        public T2[] SideB;

        public Bindings(int sizeA, int sizeB)
        {
            SideA = new T[sizeA];
            SideB = new T2[sizeB];
        }
    }
}
