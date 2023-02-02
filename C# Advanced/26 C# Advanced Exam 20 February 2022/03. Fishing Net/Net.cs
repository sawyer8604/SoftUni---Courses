using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FishingNet
{
    public class Net
    {
        private List<Fish> fish = new List<Fish>();

        public Net(string material, int capacity)
        {
            Material = material;
            Capacity = capacity;
            this.Fish = fish;
        }

        public string Material { get; private set; }
        public int Capacity { get; private set; }
        public int Count => fish.Count;
        public List<Fish> Fish { get; set; }

        public string AddFish(Fish fish)
        {
            if (string.IsNullOrWhiteSpace(fish.FishType) || fish.Weight <= 0 || fish.Length <= 0)
            {
                return "Invalid fish.";
            }

            if (Count >= Capacity)
            {
                return "Fishing net is full.";
            }

            this.fish.Add(fish);
            return $"Successfully added {fish.FishType} to the fishing net.";

        }

        public bool ReleaseFish(double weight)
        {
            var fishToRelease = this.fish.FirstOrDefault(x => x.Weight == weight);

            Fish.Remove(fishToRelease);

            if (fishToRelease == null)
            {
                return false;
            }
            return true;
        }

        public Fish GetFish(string fishType)
        {
            return this.fish.FirstOrDefault(x => x.FishType == fishType);

        }

        public Fish GetBiggestFish()
        {
            return this.fish.OrderByDescending(x => x.Length).FirstOrDefault();
        }

        public string Report()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Into the {Material}:");

            foreach (var item in this.fish.OrderByDescending(x => x.Length))
            {
                sb.AppendLine(item.ToString());
            }

            return sb.ToString().TrimEnd();
        }
    }
}
