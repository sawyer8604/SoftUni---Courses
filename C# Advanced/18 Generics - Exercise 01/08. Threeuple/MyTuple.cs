using System;
using System.Collections.Generic;
using System.Text;

namespace _08._Threeuple
{
    public class MyTuple<T, K, P>
    {
        public MyTuple(T item1, K item2, P item3)
        {
            Item1 = item1;
            Item2 = item2;
            Item3 = item3;
        }
        public T Item1 { get; set; }
        public K Item2 { get; set; }
        public P Item3 { get; set; }

        public override string ToString()
        {
            return $"{Item1} -> {Item2} -> {Item3}";
        }
    }
}
