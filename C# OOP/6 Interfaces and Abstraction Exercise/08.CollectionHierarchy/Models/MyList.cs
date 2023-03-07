using _08.CollectionHierarchy.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace _08.CollectionHierarchy.Models
{
    public class MyList : IMyList
    {
        private List<string> list;

        public MyList()
        {
            list = new List<string>();
        }
        public int Used => list.Count;

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
                item = list[0];

                list.RemoveAt(0);
            }

            return item;
        }
    }
}
