using System;

namespace CustomStructures
{
    public class Program
    {
        static void Main(string[] args)
        {
            CustomList customList = new CustomList();

            customList.Add(1);
            customList.Add(2);
            customList.Add(3);
            customList.Add(4);
            customList.Add(5);

            customList.RemoveAt(0);
            customList.RemoveAt(1);
            customList.RemoveAt(2);


            customList.Add(1);
            customList.Add(2);

            customList.Shrink();

            customList.Swap(0, 1);

            customList.Contains(3);

            customList.ForEach(x => Console.WriteLine(x));


        }
    }
}
