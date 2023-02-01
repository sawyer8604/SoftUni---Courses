using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Renovators
{
    public class Catalog
    {
        private List<Renovator> renovators;
              
        public Catalog(string name, int neededRenovators, string project)
        {
            Name = name;
            NeededRenovators = neededRenovators;
            Project = project;
            this.renovators = new List<Renovator>();
        }
        public string Name { get; private set; }
        public int NeededRenovators { get; private set; }
        public string Project { get; private set; }

        public IReadOnlyCollection<Renovator> Renovators => renovators;

        public int Count => renovators.Count;
        public string AddRenovator(Renovator renovator)
        {
            if(string.IsNullOrEmpty(renovator.Name) || string.IsNullOrEmpty(renovator.Type))
            {
                return $"Invalid renovator's information.";
            }

            else if(this.Count == this.NeededRenovators)
            {
                return $"Renovators are no more needed.";
            }

            else if(renovator.Rate > 350)
            {
                return $"Invalid renovator's rate.";
            }
            else
            {
                renovators.Add(renovator);

                return $"Successfully added {renovator.Name} to the catalog.";
            }
        }

        public bool RemoveRenovator(string name)
        {
            var removedRenovator = renovators.FirstOrDefault(x => x.Name == name);
            if(removedRenovator != null)
            {
                renovators.Remove(removedRenovator);
                return true;
            }
            return false;
        }

        public int RemoveRenovatorBySpecialty(string type)
        {
            var renovatorsToRemove = renovators.Count(x => x.Type == type);

            if (renovatorsToRemove > 0)
            {
                var playersToRemove = renovators.RemoveAll(x => x.Type == type);
               
                return renovatorsToRemove;
            }

            return 0;
           
        }

        public Renovator HireRenovator(string name)
        {
            var hiredRenovator = this.renovators.FirstOrDefault(x => x.Name == name);
            if (hiredRenovator == null)
            {
                return null;
            }
            this.Renovators.FirstOrDefault(x => x.Name == name).Hired = true;
            return hiredRenovator;
        }

        public List<Renovator> PayRenovators(int days)
        {
            List<Renovator> payRenovators = new List<Renovator>();

            foreach (var ren in this.renovators.Where(x => x.Days >= days))
            {
                payRenovators.Add(ren);
            }
            return payRenovators;
        }

        public string Report()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Renovators available for Project {this.Project}:");

            foreach (var item in this.Renovators.Where(x => x.Hired == false).Where(x => x.Paid == false))
            {
                sb.AppendLine(item.ToString());
            }
            return sb.ToString().TrimEnd();
            
        
        }

    }
}
