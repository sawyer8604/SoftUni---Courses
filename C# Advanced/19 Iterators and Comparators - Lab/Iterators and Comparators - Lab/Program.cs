using System;
using System.Collections;
using System.Collections.Generic;

namespace IntEnumerators
{
    internal class Program
    {
        static void Main(string[] args)
        {

            IntEnumerable collections = new IntEnumerable();

            foreach (var item in  collections)
            {
                Console.WriteLine(item);
            }
        }
    }
}




class IntEnumerator : IEnumerator<int>
{

    private int currentNum = 0;
    public int Current => currentNum;

    object IEnumerator.Current => Current;

    public void Dispose()    {  }

    public bool MoveNext()
    {
        if(currentNum ++ > 20)
        {
            return false;
        }
        return true;
    }

    public void Reset()
    {
        currentNum = 0;
    }
}

class IntEnumerable : IEnumerable<int>
{
    public IEnumerator<int> GetEnumerator()
    {
        return new IntEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}