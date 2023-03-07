using _08.CollectionHierarchy.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace _08.CollectionHierarchy.Models
{
    public class AddRemoveCollection : IAddRemoveCollection
    {
        private List<string> list;

        public AddRemoveCollection()
        {
            list = new List<string>();
        }
        public int Add(string item)
        {
            list.Insert(0, item);

            return 0;
        }

        public string Remove()
        {
            string item = null;

            if (list.Count > 0)
            {
                item = list[list.Count - 1];

                list.RemoveAt(list.Count - 1);
            }

            return item;
        }
    }
}
