using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysAndLists.Lists
{
    abstract class List
    {
        public abstract void Add(int value);

        public abstract void Remove(int index);

        public abstract void SearchValue(int value);

        public abstract void SearchByIndex(int index);

        public abstract void Swap(int first, int second);
    }
}
