using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace _04.Froggy
{
    internal class Lake<T> : IEnumerable<T>
    {
        List<T> stones;

        public Lake(List<T> stones)
        {
            this.stones = stones;
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < stones.Count; i++)
            {
                if(i % 2 == 0)
                {
                    yield return stones[i];              
                }
                

            }

            for (int i = stones.Count - 1; i >= 0; i--)
            {
                if (i % 2 != 0)
                {
                    yield return stones[i];
                }
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
        
    }
}
