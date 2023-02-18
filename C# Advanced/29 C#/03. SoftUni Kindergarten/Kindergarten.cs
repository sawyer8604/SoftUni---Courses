using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SoftUniKindergarten
{
    public class Kindergarten
    {
        private List<Child> registry;

        public Kindergarten(string name, int capacity)
        {
            Name = name;
            Capacity = capacity;
            registry = new List<Child>();
        }

        public string Name { get; private set; }
        public int Capacity { get; private set; }
        public List<Child> Registry => registry;

        public int ChildrenCount => Registry.Count;

        public bool AddChild(Child child)
        {
            if (Registry.Count < Capacity)
            {
                Registry.Add(child);
                return true;
            }

            return false;
        }

        public bool RemoveChild(string childFullName)
        {
            var removeChild = Registry.FirstOrDefault(x => x.FullName == childFullName);

            if (removeChild != null)
            {
                Registry.Remove(removeChild);

                return true;
            }

            return false;

        }

        public Child GetChild(string childFullName)
        {
            return Registry.FirstOrDefault(x => x.FullName == childFullName);
        }

        public string RegistryReport()
        {
            if(Registry.Any())
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendLine($"Registered children in {Name}:");

                foreach (var item in Registry.OrderByDescending(x => x.Age).ThenBy(x => x.LastName).ThenBy(x => x.FirstName))
                {
                    sb.AppendLine(item.ToString());
                }

                return sb.ToString().TrimEnd();
            }
            return null;
            
        }
    }
}
