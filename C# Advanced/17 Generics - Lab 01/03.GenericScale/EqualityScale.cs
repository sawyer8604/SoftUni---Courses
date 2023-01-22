using System;
using System.Collections.Generic;
using System.Text;

namespace _03.GenericScale
{
    public class EqualityScale<T>
    {
        T left;
        T right;

        public EqualityScale(T left, T right)
        {
            this.left = left;
            this.right = right;
        }

        public bool AreEqual()
        {
            return left.Equals(right);
        }
    }
}
