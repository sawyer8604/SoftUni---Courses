﻿using _08.CollectionHierarchy.Models;
using _08.CollectionHierarchy.Models.Interfaces;
using System;
using System.Collections.Generic;

namespace _08.CollectionHierarchy
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<int>> addedIndexes = new Dictionary<string, List<int>>();

            addedIndexes.Add("AddCollection", new List<int>());
            addedIndexes.Add("AddRemoveCollection", new List<int>());
            addedIndexes.Add("MyList", new List<int>());



            Dictionary<string, List<string>> removedItems = new Dictionary<string, List<string>>();

            removedItems.Add("AddCollection", new List<string>());
            removedItems.Add("AddRemoveCollection", new List<string>());
            removedItems.Add("MyList", new List<string>());

            IAddCollection addCollection = new AddCollection();
            IAddRemoveCollection addRemoveCollection = new AddRemoveCollection();
            IMyList myList = new MyList();

            string[] items = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            foreach (var item in items)
            {
                addedIndexes["AddCollection"].Add(addCollection.Add(item));

                addedIndexes["AddRemoveCollection"].Add(addRemoveCollection.Add(item));

                addedIndexes["MyList"].Add(myList.Add(item));
            }

            int removeCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < removeCount; i++)
            {
                removedItems["AddRemoveCollection"].Add(addRemoveCollection.Remove());
                removedItems["MyList"].Add(myList.Remove());
            }

            Console.WriteLine(string.Join(" ", addedIndexes["AddCollection"]));
            Console.WriteLine(string.Join(" ", addedIndexes["AddRemoveCollection"]));
            Console.WriteLine(string.Join(" ", addedIndexes["MyList"]));

            Console.WriteLine(string.Join(" ", removedItems["AddRemoveCollection"]));
            Console.WriteLine(string.Join(" ", removedItems["MyList"]));
        }
    }
}
