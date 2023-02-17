using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShoeStore
{
    public class ShoeStore
    {
        private List<Shoe> shoes;

        public ShoeStore(string name, int storageCapacity)
        {
            Name = name;
            StorageCapacity = storageCapacity;
            shoes = new List<Shoe>();
        }

        public string Name { get; set; }
        public int StorageCapacity { get; set; }
        public List<Shoe> Shoes => shoes;

        public int Count => Shoes.Count;
        public string AddShoe(Shoe shoe)
        {
            if (Shoes.Count == StorageCapacity)
            {
                return "No more space in the storage room.";
            }

            shoes.Add(shoe);
            return $"Successfully added {shoe.Type} {shoe.Material} pair of shoes to the store.";
        }

        public int RemoveShoes(string material)
        {
            return shoes.RemoveAll(x => x.Material == material);

        }

        public List<Shoe> GetShoesByType(string type)
        {
            return shoes.FindAll(x => x.Type.ToLower() == type.ToLower());
        }

        public Shoe GetShoeBySize(double size)
        {
            return shoes.FirstOrDefault(x => x.Size == size);
        }

        public string StockList(double size, string type)
        {
            var list = shoes.Where(x => x.Size == size && x.Type == type);
            StringBuilder sb= new StringBuilder();
            if(list.Any())
            {
                sb.AppendLine($"Stock list for size {size} - {type} shoes:");

                foreach (var shoe in list)
                {
                    sb.AppendLine(shoe.ToString());
                }
            }
            else
            {
                sb.AppendLine("No matches found!");
            }
            
            return sb.ToString().TrimEnd();
        }
    }
}
