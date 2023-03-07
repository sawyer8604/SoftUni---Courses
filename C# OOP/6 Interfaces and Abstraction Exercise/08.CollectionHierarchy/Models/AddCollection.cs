using _08.CollectionHierarchy.Models.Interfaces;
using System;
using System.Collections.Generic;

namespace _08.CollectionHierarchy.Models
{
    public class AddCollection : IAddCollection
    {
        private List<string> list;

        public AddCollection()
        {
            list = new List<string>();
        }

        public int Add(string item)
        {
            list.Add(item);

            return list.Count - 1;
        }
    }
}
