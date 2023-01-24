using System;
using System.Collections.Generic;
using System.Text;

namespace CustomRandomList
{
    public class RandomList : List<string>
    {
        Random random = new Random();
        public string RandomString()
        {
            int index = random.Next(1, Count);
            string removedElement = this[index];
            RemoveAt(index);

            return removedElement;
        }
    }
}
